using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10___Adding_to_Resources_Programming_Assignment
{
    public partial class Topic10 : Form
    {
        string cpuText = "A CPU (Central Processing Unit) is the \"brain\" of a computer, responsible for interpreting and executing instructions from software, performing calculations, and managing data flow.";
        string ramText = "Random Access Memory (RAM) is a computer's high-speed, volatile short-term memory that temporarily stores active data and applications for quick access by the CPU.";
        string ssdText = "A Solid-State Drive (SSD) is a high-speed, non-volatile data storage device used in computers, utilizing NAND flash memory instead of magnetic disks.";
        string psuText = "A Power Supply Unit (PSU) is an internal hardware component in a computer or server that converts high-voltage alternating current (AC) from a wall outlet into low-voltage direct current (DC) needed for internal components to function. It is the foundational component that powers the motherboard, CPU, GPU, and storage drives.";
        string outputText = "An output device is any computer hardware component that receives data from a computer and converts it into a human-perceptible form, such as text, graphics, audio, or video.";
        string inputText = "An input device is a hardware component that allows a user to enter data, commands, or signals into a computer for processing";
        public Topic10()
        {
            InitializeComponent();
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            lblDescription.Text = cpuText;
            
            btnCPU.Enabled = false;
            lblDescription.Visible = true;
            CheckQuit();
            imgPicture.Image = Properties.Resources.CPU;
            VisablePicture();
        }
        public void CheckQuit()
        {
            if (btnCPU.Enabled == false && btnSSD.Enabled == false && btnPSU.Enabled == false && btnRAM.Enabled == false && btnOutput.Enabled == false && btnInput.Enabled == false)
            {
                {
                    btnQuit.Visible = true;                       
                }
            }
        }
       

        private void btnRAM_Click(object sender, EventArgs e)
        {
           lblDescription.Text = ramText;
            
            btnRAM.Enabled = false;
            
            CheckQuit();
            imgPicture.Image = Properties.Resources.RAM;
            VisablePicture();
            lblDescription.Visible = true;
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            lblDescription.Text = ssdText;
           
            btnSSD.Enabled = false;
           
            CheckQuit();
            imgPicture.Image = Properties.Resources.SSD;
            VisablePicture();
            lblDescription.Visible = true;
        }

        private void btnPSU_Click(object sender, EventArgs e)
        {
            lblDescription.Text = psuText;
           
            btnPSU.Enabled = false;
            
            CheckQuit();
            imgPicture.Image = Properties.Resources.PSU;
            VisablePicture();
            lblDescription.Visible = true;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            lblDescription.Text = outputText;
           
            btnOutput.Enabled = false;
            
            CheckQuit();
            imgPicture.Image = Properties.Resources.Output_Devices;
            VisablePicture();
            lblDescription.Visible = true;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            lblDescription.Text = inputText;
           
            btnInput.Enabled = false;
            
            CheckQuit();
            imgPicture.Image = Properties.Resources.Input_Devices;
            VisablePicture();
            lblDescription.Visible = true;
        }
        public void VisablePicture()
        {

            imgPicture.Visible = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
