﻿/*
 *	Random Crosshair Generator with GUI
 *	
 *	Version: 1.1.2
 * 
 *	Made by: ZeoN
 * 
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rcg_test
{
    public partial class Form1 : Form
    {
		// File locations
		string CommandListFile = "Command_list.txt"; // The file that hold of the needed commands.
		string RandomCrosshairFile = "RandomCrosshair/random_crosshair.txt"; // The file where all of the generated commands are going to be stored.
		string CrosshairCfgFile = "RandomCrosshair/rCross.cfg"; // Cfg with all the generated commands.

		public Form1()
        {
            InitializeComponent();

			fileTxtName.Text = RandomCrosshairFile;
			fileCfgName.Text = CrosshairCfgFile;
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

		}

        private void button1_Click(object sender, EventArgs e)
        {
			if (String.IsNullOrEmpty(fileTxtName.Text))
			{
				OutputTextBox.AppendText("<REPORTER>: The file path and name box is empty.");
				OutputTextBox.AppendText("<REPORTER>: To work fill out the box.");
			}

			else if (String.IsNullOrEmpty(fileCfgName.Text))
			{
				OutputTextBox.AppendText("<REPORTER>: The cfg path and name box is empty.");
				OutputTextBox.AppendText("<REPORTER>: To work fill out the box.");
			}

			else if (String.IsNullOrEmpty(fileTxtName.Text) && String.IsNullOrEmpty(fileCfgName.Text))
			{
				OutputTextBox.AppendText("<REPORTER>: The file path and name box is empty.");
				OutputTextBox.AppendText("<REPORTER>: To work fill out the box.");

				OutputTextBox.AppendText("<REPORTER>: The cfg path and name box is empty.");
				OutputTextBox.AppendText("<REPORTER>: To work fill out the box.");
			}

			else
			{
				CH_Generate();
			}
        }

		public void CH_Generate()
		{
			OutputTextBox.ResetText();

			OutputTextBox.AppendText("###############################################\n");
			OutputTextBox.AppendText("	RANDOM CROSSHAIR GENERATOR	\n");
			OutputTextBox.AppendText("###############################################\n");

			OutputTextBox.AppendText("<REPORTER>: Checking ");
			OutputTextBox.AppendText(CommandListFile);
			OutputTextBox.AppendText("\n");

			if (File.Exists(CommandListFile) != true) // Will output this if the command list file is not found
			{
				OutputTextBox.AppendText("<REPORTER>: File ");
				OutputTextBox.AppendText(CommandListFile);
				OutputTextBox.AppendText(" was not found. \n");
			}

			else // Will execute if the command list file exists
			{
				OutputTextBox.AppendText("<REPORTER>: File ");
				OutputTextBox.AppendText(CommandListFile);
				OutputTextBox.AppendText(" - found.\n");

				OutputTextBox.AppendText("<REPORTER>: Reading ");
				OutputTextBox.AppendText(CommandListFile);
				string GetCrossCommands = File.ReadAllText(CommandListFile); // Copies all of the conent form the file
				OutputTextBox.AppendText(" - Done!\n");

				if (File.Exists(RandomCrosshairFile) != true) // Checks if the random crosshair .txt exists
				{
					OutputTextBox.AppendText("<REPORTER>: Creating ");
					OutputTextBox.AppendText(RandomCrosshairFile);
					OutputTextBox.AppendText(" - ");
					File.WriteAllText(RandomCrosshairFile, "//Random Crosshair \n");
				}

				else // If the old one exists it's going to be deleted and replaces with a new one
				{
					OutputTextBox.AppendText("<REPORTER>: Deleting old ");
					OutputTextBox.AppendText(RandomCrosshairFile);
					OutputTextBox.AppendText(" - ");
					File.Delete(RandomCrosshairFile);
					OutputTextBox.AppendText("Done!\n");

					OutputTextBox.AppendText("<REPORTER>: Creating ");
					OutputTextBox.AppendText(RandomCrosshairFile);
					OutputTextBox.AppendText(" - ");
					File.WriteAllText(RandomCrosshairFile, "//Random Crosshair \n");
				}
				OutputTextBox.AppendText("Done!\n");

				OutputTextBox.AppendText("<REPORTER>: Staring to write commands to ");
				OutputTextBox.AppendText(RandomCrosshairFile);
				OutputTextBox.AppendText("\n");

				int StartPoints = 0; // For storing the location where a commands beigns.
				string CommandGet = ""; // For Holding a command.

				MyFunctions obj = new MyFunctions();

				// Start of number finding and seperation
				int sizeOfString = obj.StringSize(GetCrossCommands); // Gets the whole size of the copied file.
				for (int i = 0; i < sizeOfString; i++)
				{
					if (GetCrossCommands[i] == ';')
					{
						for (int j = StartPoints; j < i; j++)
						{
							CommandGet = CommandGet + GetCrossCommands[j];
						}

						string firstNumber = "";
						string lastNumber = "";
						int semPoint = 0;
						int firstLimit = 0;
						int lastLimit = 50;

						for (int j = 0; j < obj.StringSize(CommandGet); j++)
						{
							if (CommandGet[j] == 45 || (CommandGet[j] >= 48 && CommandGet[j] <= 57))
							{
								firstNumber = firstNumber + CommandGet[j];
							}

							else if (CommandGet[j] == ',')
							{
								semPoint = j;
								break;
							}
						}

						for (int j = semPoint; j < obj.StringSize(CommandGet); j++)
						{
							if (CommandGet[j] >= 48 && CommandGet[j] <= 57)
							{
								lastNumber = lastNumber + CommandGet[j];
							}
						}

						firstLimit = Int32.Parse(firstNumber);
						lastLimit = Int32.Parse(lastNumber);

						OutputTextBox.AppendText("<REPORTER>: ");

						String CommandHolder = "";
						for (int j = StartPoints; j < i; j++) // For command making and will output the command in the console.
						{
							if ((GetCrossCommands[j] >= 97 && GetCrossCommands[j] <= 122) || (GetCrossCommands[j] >= 65 && GetCrossCommands[j] <= 90) || GetCrossCommands[j] == 95)
							{
								CommandHolder = CommandHolder + GetCrossCommands[j];
							}
						}
						OutputTextBox.AppendText(CommandHolder);

						Random rnd = new Random();
						CommandGet = CommandHolder + " " + rnd.Next(firstLimit, lastLimit) + ";\n"; // Will generate a random number after the command.

						File.AppendAllText(RandomCrosshairFile, CommandGet); // Writes the generated commad to the file.

						OutputTextBox.AppendText(" - Done!\n");

						CommandGet = ""; // Clears the string with the command.
						StartPoints = i + 1; // Sets the beiging of the next command.
					}
				}
				// End of number finding and seperation

				// Start of cfg making
				OutputTextBox.AppendText("<REPORTER>: Checking for ");
				OutputTextBox.AppendText(CrosshairCfgFile);
				OutputTextBox.AppendText("\n");

				if (File.Exists(CrosshairCfgFile) != false) // If the old cfg exists it will be deleted and a new one is going to be created.
				{
					OutputTextBox.AppendText("<REPORTER>: Found cfg file.\n");

					OutputTextBox.AppendText("<REPORTER>: Deleting old ");
					OutputTextBox.AppendText(CrosshairCfgFile);
					File.Delete(CrosshairCfgFile);
					OutputTextBox.AppendText(" - Done!\n");

					OutputTextBox.AppendText("<REPORTER>: Creating new ");
					OutputTextBox.AppendText(CrosshairCfgFile);
					File.WriteAllText(CrosshairCfgFile, "//cfg file \n");
					OutputTextBox.AppendText(" - Done!\n");
				}

				else // If the cfg file does not exists it will create one.
				{
					OutputTextBox.AppendText("<REPORTER>: Creating ");
					OutputTextBox.AppendText(CrosshairCfgFile);
					File.WriteAllText(CrosshairCfgFile, "//cfg file \n");
					OutputTextBox.AppendText(" - Done!\n");
				}

				if (File.Exists(CrosshairCfgFile) != false) // If the cfg Exists it will write all of the commands to it.
				{
					OutputTextBox.AppendText("<REPORTER>: Writing to ");
					OutputTextBox.AppendText(CrosshairCfgFile);

					string GetRandomCrosshair = File.ReadAllText(RandomCrosshairFile); // Reads and copies the generated crosshair.
					File.AppendAllText(CrosshairCfgFile, GetRandomCrosshair); // Places all of the text into the cfg file.

					OutputTextBox.AppendText(" - Done!\n");
				}
				// End of cfg making
			}

			OutputTextBox.AppendText("<REPORTER>: Process ended.\n");

			OutputTextBox.AppendText("###############################################\n");
			OutputTextBox.AppendText("        Crosshair can be found in the RandomCrosshair folder\n");
			OutputTextBox.AppendText("###############################################\n");
		}

		private void setTxtName_Click(object sender, EventArgs e)
		{
			RandomCrosshairFile = setTxtName.Text;
			
			fileTxtName.Text = RandomCrosshairFile;
			fileCfgName.Text = CrosshairCfgFile;
		}

		private void setCfgName_Click(object sender, EventArgs e)
		{
			CrosshairCfgFile = fileCfgName.Text;

			fileTxtName.Text = RandomCrosshairFile;
			fileCfgName.Text = CrosshairCfgFile;
		}

		private void fileTxtName_TextChanged(object sender, EventArgs e)
		{

		}
	}

	class MyFunctions
	{
		public int StringSize(string inputString) // Will return the size of a string
		{
			int returnSize = 0;

			foreach (char x in inputString)
			{
				returnSize++;
			}

			return returnSize;
		}
	}
}