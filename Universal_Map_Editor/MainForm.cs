using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Universal_Map_Editor
{
    public partial class MainForm : Form
    {
        #region Global Variables
        private string _workingDirectory = Directory.GetCurrentDirectory();

        private DoubleBuffer dBuffer;
        private Graphics bGraphics;

        private TileMap map = new TileMap(100, 20);

        private int tileSize = 16;
        private int mapDrawOffset = 0;
        private int currentTileType = 9999;
        private bool drawingTiles = false;
        private string currentFile = null;
        private bool mapChanged = false;

        private string[] filePaths;
        private string[] tileAssociation;

        Bitmap[] tileImages;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private bool populateTileList()
        {
            string tileDirectory = (_workingDirectory + @"\tiles\");

            if (Directory.Exists(tileDirectory))
            {
                filePaths = Directory.GetFiles(tileDirectory, "*.bmp");
                tileImages = new Bitmap[filePaths.Length];
                tileAssociation = new string[filePaths.Length];

                for (int i = 0; i < filePaths.Length; i++)
                {
                    tileImages[i] = new Bitmap(Bitmap.FromFile(filePaths[i]));
                    filePaths[i] = filePaths[i].Substring(tileDirectory.Length, (filePaths[i].Length - tileDirectory.Length) - 4);

                    int underscoreLocation = filePaths[i].IndexOf("_");

                    string tempName = filePaths[i].Substring(0, underscoreLocation);
                    tileAssociation[i] = tempName;
                }

                tileListBox.Items.Clear();
                tileListBox.Items.AddRange(filePaths);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool populateDefsList()
        {
            string defsDirectory = (_workingDirectory + @"\settings\");
            string[] configPaths;

            if(Directory.Exists(defsDirectory))
            {
                configPaths = Directory.GetFiles(defsDirectory, "*.cfg");

                if(configPaths.Length > 0)
                {
                    for (int i = 0; i < configPaths.Length; i++)
                    {
                        configPaths[i] = configPaths[i].Substring(defsDirectory.Length, (configPaths[i].Length - defsDirectory.Length) - 4);
                    }

                    mapDefDropDown.Items.Clear();
                    mapDefDropDown.Items.AddRange(configPaths);
                    mapDefDropDown.SelectedIndex = 0;
                }
                else
                {
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool loadSettings()
        {
            string settingsPath = _workingDirectory + @"\settings\Settings.ini";

            if (File.Exists(settingsPath))
            {
                FileStream stream = new FileStream(settingsPath, FileMode.Open);
                StreamReader reader = new StreamReader(stream);

                string textLine;
                string textPart;

                while (reader.EndOfStream == false)
                {
                    textLine = reader.ReadLine();

                    if(textLine.ToLower().StartsWith("tilesize:"))
                    {
                        textPart = textLine.Remove(0, 9);
                        tileSizeDropDown.SelectedIndex = int.Parse(textPart);
                    }
                }

                reader.Close();
                stream.Close();
            }
            else
            {
                return false;
            }

            return true;
        }

        private bool saveSettings()
        {
            string settingsPath = _workingDirectory + @"\settings\Settings.ini";

            if (File.Exists(settingsPath))
            {
                FileStream stream = new FileStream(settingsPath, FileMode.Open);
                StreamWriter writer = new StreamWriter(stream);
                
                if (stream.CanWrite)
                {
                    writer.Write("tilesize:" + tileSizeDropDown.SelectedIndex);
                }

                writer.Close();
                stream.Close();
            }
            else
            {
                return false;
            }

            return true;
        }

        #region Map Editor Methods
        private void drawMapRegion()
        {
            dBuffer.g.FillRectangle(Brushes.Black, 0, 0, displayPanel.Width, displayPanel.Height);

            for (int x = 0; x < map.width; x++)
            {
                for (int y = 0; y < map.height; y++)
                {
                    drawMapTile(x, y);
                }
            }

            dBuffer.RenderToGraphics(bGraphics);
        }

        private void drawMapTile(int x, int y)
        {
            if (map.mapData[x, y] == 9999)
            {
                dBuffer.g.FillRectangle(Brushes.Black, (x - mapDrawOffset) * tileSize, y * tileSize, tileSize, tileSize);
            }
            else
            {
                dBuffer.g.DrawImage(tileImages[map.mapData[x, y]], (x - mapDrawOffset) * tileSize, y * tileSize, tileSize, tileSize);
            }
        }

        private void changeTile(MouseEventArgs e)
        {
            if (currentTileType != 9999)
            {
                if ((e.Location.Y > 0) && (e.Location.Y < displayPanel.Height) && (e.Location.X > 0) && (e.Location.X < displayPanel.Width))
                {
                    map.mapData[(int)(Math.Floor(((float)e.Location.X + ((float)mapDrawOffset * (float)tileSize)) / (float)tileSize)), (int)Math.Floor((float)e.Location.Y / (float)tileSize)] = currentTileType;

                    drawMapTile((int)(Math.Floor(((float)e.Location.X + ((float)mapDrawOffset * (float)tileSize)) / (float)tileSize)), (int)Math.Floor((float)e.Location.Y / (float)tileSize));

                    dBuffer.RenderToGraphics(bGraphics);
                    mapChanged = true;
                }
            }
        }

        private void initializeMap(int value)
        {
            currentFile = null;
            currentLoadedFile.Text = "File: None Loaded";

            for (int x = 0; x < map.width; x++)
            {
                for (int y = 0; y < map.height; y++)
                {
                    map.mapData[x, y] = value;
                }
            }

            drawMapRegion();
            mapChanged = false;
        }
        #endregion

        #region Menu Events
        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadMapDialog.ShowDialog() == DialogResult.OK)
            {
                if (loadMapFile(loadMapDialog.FileName))
                {
                    currentFile = loadMapDialog.FileName;
                    currentLoadedFile.Text = "File: " + currentFile;
                    drawMapRegion();
                    mapChanged = false;
                }
                else
                {
                    MessageBox.Show("There was an error during map loading.\n\nLoading failed.", "Map Load Failed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    initializeMap(0);
                }
            }
        }

        private void saveMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFile != null)
            {
                saveCurrentFile(currentFile);
                mapChanged = false;
            }
            else
            {
                if (saveMapDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFile = saveMapDialog.FileName;
                    saveCurrentFile(currentFile);
                    currentLoadedFile.Text = "File: " + currentFile;
                    mapChanged = false;
                }
                else
                {
                    MessageBox.Show("File was not saved.");
                }
            }
        }

        private void saveMapAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveMapDialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = saveMapDialog.FileName;
                saveCurrentFile(currentFile);
                currentLoadedFile.Text = "File: " + currentFile;
                mapChanged = false;
            }
            else
            {
                MessageBox.Show("File was not saved.");
            }
        }

        private void saveCurrentFile(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);

            for (int y = 0; y < map.height; y++)
            {
                for (int x = 0; x < map.width; x++)
                {
                    if (stream.CanWrite)
                    {
                        writer.Write(tileAssociation[map.mapData[x, y]]);

                        if (x < (map.width - 1))
                        {
                            writer.Write(" ");
                        }
                    }
                }

                writer.WriteLine();
            }

            writer.Close();
            stream.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettings();
            Form.ActiveForm.Close();
        }
        #endregion
        
        #region Form Events
        private void mapScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            mapDrawOffset = e.NewValue;
            drawMapRegion();
        }

        private void displayPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingTiles)
            {
                if (e.X < ((map.width - mapDrawOffset) * tileSize))
                {
                    if (e.Y < map.height * tileSize)
                    {
                        changeTile(e);
                    }
                }
            }
        }

        private void displayPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drawingTiles = false;
        }

        private void displayPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drawingTiles = true;

            if (e.X < ((map.width - mapDrawOffset) * tileSize))
            {
                if (e.Y < map.height * tileSize)
                {
                    changeTile(e);
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ///* Create graphics */
            bGraphics = displayPanel.CreateGraphics();
            dBuffer = new DoubleBuffer();
            dBuffer.CreateBuffer(bGraphics, displayPanel.Width, displayPanel.Height);

            if (populateTileList())
            {
                // Definitions loaded successfully
                //MessageBox.Show("Definitions loaded.");
            }
            else
            {
                MessageBox.Show("No tiles found in the /tiles/ folder.");
                Environment.Exit(0);
            }

            if (populateDefsList())
            {
                // Definitions loaded successfully
                //MessageBox.Show("Definitions loaded.");
            }
            else
            {
                MessageBox.Show("No definitions found in the /settings/ folder.");
                Environment.Exit(0);
            }

            if (loadSettings())
            {
                // Settings loaded successfully
                //MessageBox.Show("Settings loaded.");
            }
            else
            {
                MessageBox.Show("No settings found in the /settings/ folder.");
                Environment.Exit(0);
            }

            // Initialize map
            initializeMap(1);
        }
        #endregion

        private Vector GetMapSize(string filename)
        {
            FileStream fileStream = new FileStream(filename, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);

            string textLine;
            string[] textParts;
            int x = 0;
            int y = 0;

            while (streamReader.EndOfStream == false)
            {
                x = 0;

                textLine = streamReader.ReadLine();
                textParts = textLine.Split(' ');

                foreach (string text in textParts)
                {
                    x++;
                }
                y++;
            }

            streamReader.Close();
            fileStream.Close();

            return (new Vector(x, y));
        }

        private bool loadMapFile(string fileName)
        {
            Vector mapSize = GetMapSize(fileName);
            map.width = mapSize.X;
            map.height = mapSize.Y;
            map.mapData = new int[mapSize.X, mapSize.Y];

            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);

            string textLine;
            string[] textParts;
            int x = 0;
            int y = 0;
            int tile = 0;

            while (reader.EndOfStream == false)
            {
                x = 0;

                textLine = reader.ReadLine();
                textParts = textLine.Split(' ');

                foreach (string text in textParts)
                {
                    tile = ProcessTile(text);

                    if (tile != -1)
                    {
                        map.mapData[x, y] = tile;
                    }
                    else
                    {
                        File.WriteAllText("ErrorLog.txt", "Failed tile at [" + x + "," + y + "].");
                        MessageBox.Show("Some tiles missing. Please check tile folder contains all tiles for this map.", "Tiles Missing.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    //drawMapTile(x, y);
                    mapChanged = true;

                    x++;
                }

                y++;
            }

            //dBuffer.RenderToGraphics(bGraphics);
            drawMapRegion();

            reader.Close();
            stream.Close();

            return true;
        }

        private int ProcessTile(string text)
        {
            int i = 0;
            bool tileFound = false;

            while(tileFound == false)
            {
                if (i < tileAssociation.Length)
                {
                    tileFound = Equals(tileAssociation[i], text);

                    i += 1;
                }
                else
                {
                    return -1;
                }
            }

            return (i-1);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();

            if (mapChanged)
            {
                switch (MessageBox.Show("There are unsaved changes to the map.\nWould you like to save the changes to the current map file?", "Save Changes?", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        if (currentFile != null)
                        {
                            saveCurrentFile(currentFile);
                        }
                        else
                        {
                            if (saveMapDialog.ShowDialog() == DialogResult.OK)
                            {
                                currentFile = saveMapDialog.FileName;
                                saveCurrentFile(currentFile);
                                currentLoadedFile.Text = "File: " + currentFile;
                            }
                            else
                            {
                                MessageBox.Show("File was not saved.");
                                e.Cancel = true;
                            }
                        }
                        break;
                    case DialogResult.No:
                        // Exit, not saving changes.
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        drawMapRegion();
                        break;
                }
            }
        }

        private void mapFileSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapFileOptionsForm optionsForm = new MapFileOptionsForm();
            optionsForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tileListBox.SelectedIndex < filePaths.Length)
            {
                currentTileType = tileListBox.SelectedIndex;
            }
        }

        private void repopTileListButton_Click(object sender, EventArgs e)
        {
            populateTileList();
        }

        private void newMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initializeMap(9999);
        }

        private void tileSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tileSize = int.Parse(tileSizeDropDown.Items[tileSizeDropDown.SelectedIndex].ToString().Remove(2));
            
            drawMapRegion();
        }

        private void versionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionLogForm verForm = new VersionLogForm();
            verForm.Show();
        }

        private void displayPanel_Resize(object sender, EventArgs e)
        {
            bGraphics = displayPanel.CreateGraphics();
            dBuffer = new DoubleBuffer();
            dBuffer.CreateBuffer(bGraphics, displayPanel.Width, displayPanel.Height);

            drawMapRegion();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            drawMapRegion();
        }

        private void openTileFolderButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Explorer.exe", _workingDirectory + "\\tiles");
        }
    }
}
