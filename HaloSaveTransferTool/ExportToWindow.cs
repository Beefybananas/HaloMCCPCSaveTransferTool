﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HaloMCCPCSaveTransferTool;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace HaloMCCPCSaveTransferTool
{
    public partial class ExportToWindow : Form
    {
        internal static string selectedDirectory;
        internal static Choice choice;
        internal static string extention;
        //public static 
        internal enum Choice
        {
            BuiltIn,
            Private,
            Other,
            Unselected
        }
        public ExportToWindow()
        {
            InitializeComponent();
            choice = Choice.Unselected;
            extention = null;
            selectedDirectory = null;
            BuiltIn.Enabled = Directory.Exists(Properties.Settings.Default.BuiltInLocation);
            Private.Enabled = Directory.Exists(Properties.Settings.Default.PrivateLocation);
        }
        internal static string GetResult(HaloX360FileIO.ContainerInfo containerInfo)
        {
            if (new ExportToWindow().ShowDialog() == DialogResult.OK)
            {
                if (selectedDirectory != null)
                {
                    extention = GetExtention(containerInfo);
                    return selectedDirectory;
                }
            }
            return null;
        }
        void SetOther(object sender = null, EventArgs e = null)
        {
            string selectedOtherDirectory = Properties.Settings.Default.DefaultOtherLocation;
            if (!Directory.Exists(selectedOtherDirectory)) selectedOtherDirectory = @"C:\";
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog();
            openFileDialog.RestoreDirectory = false;
            openFileDialog.IsFolderPicker = true;
            openFileDialog.InitialDirectory = selectedOtherDirectory;
            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok && Directory.Exists(openFileDialog.FileName))
            {
                selectedOtherDirectory = openFileDialog.FileName;
                SetSelected(selectedOtherDirectory, Choice.Other);
            }
        }

        private void BuiltIn_Click(object sender, EventArgs e)
        {
            SetSelected(Properties.Settings.Default.BuiltInLocation, Choice.BuiltIn);
        }

        private void Private_Click(object sender, EventArgs e)
        {
            SetSelected(Properties.Settings.Default.PrivateLocation, Choice.Private);
        }
        void SetSelected(string directory, Choice choiceMade = Choice.Unselected)
        {
            if (Directory.Exists(directory))
            {
                selectedDirectory = directory;
                choice = choiceMade;
                DialogResult = DialogResult.OK;
            }
        }
        internal static string GetDirectory(HaloX360FileIO.ContainerInfo containerInfo)
        {
            string location = @"C:\";
            if (choice == Choice.BuiltIn)
            {
                try { location = GetBuiltInDirectory(containerInfo); }
                catch (Exception e) { MainWindow.Output.WriteLine(e.Message); }
            }
            else if (choice == Choice.Private)
            {
                try { location = GetPrivateDirectory(containerInfo); }
                catch (Exception e) { MainWindow.Output.WriteLine(e.Message); }
            }
            else if (choice == Choice.Other)
            {
                return GetOtherDirectoryAsChoice(containerInfo);
            }
            return location;
        }
        internal static string GetOtherDirectory()
        {
            string otherLocation = Properties.Settings.Default.DefaultOtherLocation;
            if (otherLocation != null && Directory.Exists(otherLocation))
            {
                return otherLocation;
            }
            else { return @"C:\"; }
        }
        static string GetOtherDirectoryAsChoice(HaloX360FileIO.ContainerInfo containerInfo)
        {
            string otherLocation = Properties.Settings.Default.DefaultOtherLocation;
            if (otherLocation != null && Directory.Exists(otherLocation))
            {
                extention = GetExtention(containerInfo);
                choice = Choice.Other;
                return otherLocation;
            }
            else { return @"C:\"; }
        }
        internal static string GetExtention(HaloX360FileIO.ContainerInfo containerInfo)
        {
            if (containerInfo.CON.Header.Title_Package == "Halo: Reach")
            {
                if (containerInfo.file.Name == "sandbox.map") return ".mvar";
                else if (containerInfo.file.Name == "variant") return ".bin";
                else
                {
                    throw new Exception("Could not get extention for " + containerInfo.file.Name);
                }
            }
            throw new Exception("Could not get file name from container");
        }
        internal static string GetPrivateDirectory(HaloX360FileIO.ContainerInfo containerInfo)
        {
            string privateLocaiton = Properties.Settings.Default.PrivateLocation;
            if (privateLocaiton != null && Directory.Exists(privateLocaiton))
            {
                if (containerInfo.CON.Header.Title_Package == "Halo: Reach")
                {
                    string returnLocation = privateLocaiton + @"\HaloReach";
                    if (!Directory.Exists(returnLocation)) throw new Exception("Halo Reach folder not found");
                    if (containerInfo.file.Name == "sandbox.map")
                    {
                        returnLocation += @"\Map";
                        extention = ".mvar";
                        if (!Directory.Exists(returnLocation)) throw new Exception("Map Variants folder not found");
                        return returnLocation;
                    }
                    else if (containerInfo.file.Name == "variant")
                    {
                        returnLocation += @"\GameType";
                        extention = ".bin";
                        if (!Directory.Exists(returnLocation)) throw new Exception("Game Variants folder not found");
                        return returnLocation;
                    }
                }
            }

            throw new Exception("Failed to get private folder location");
        }
        internal static string GetBuiltInDirectory(HaloX360FileIO.ContainerInfo containerInfo)
        {
            string builtInLocaiton = Properties.Settings.Default.BuiltInLocation;
            if (builtInLocaiton != null && Directory.Exists(builtInLocaiton))
            {
                if (containerInfo.CON.Header.Title_Package == "Halo: Reach")
                {
                    string returnLocation = builtInLocaiton + @"\haloreach";
                    if (!Directory.Exists(returnLocation)) throw new Exception("Halo Reach folder not found");
                    if (containerInfo.file.Name == "sandbox.map")
                    {
                        returnLocation += @"\map_variants";
                        extention = ".mvar";
                        if (!Directory.Exists(returnLocation)) throw new Exception("Map Variants folder not found");
                        return returnLocation;
                    }
                    else if (containerInfo.file.Name == "variant")
                    {
                        returnLocation += @"\game_variants";
                        extention = ".bin";
                        if (!Directory.Exists(returnLocation)) throw new Exception("Game Variants folder not found");
                        return returnLocation;
                    }
                }
            }
            throw new Exception("Failed to get built in folder location");
        }
    }
}
