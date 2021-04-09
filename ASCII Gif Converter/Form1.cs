using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

using BrailleText;

namespace ASCII_Gif_Converter
{
    public partial class Form1 : Form
    {
        Bitmap gif;
        string path;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                gif = new Bitmap(dialog.FileName);
                
                if(gif != null)
                {
                    path = txtDir.Text + "\\" + txtName.Text;

                    if(!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    int frameCount = gif.GetFrameCount(FrameDimension.Time);
                    int fontSize = (int)(numFontSize.Value * numInterval.Value);
                    Font f = new Font("Lucida Console", fontSize, FontStyle.Regular);
                    //font height ~ 1.35*size

                    int maxWidth = 0;
                    int maxHeight = 0;

                    for (int i = 0; i < frameCount; i++)
                    {
                        float width = 0;
                        float height = 0;
                        string[] rows = new string[gif.Height];
                        int[] points = new int[gif.Height];
                        gif.SelectActiveFrame(FrameDimension.Time, i);
                        int k = 0;
                        float interval = (float)numInterval.Value;
                        for(float y = 0; y < gif.Height; y += 3*interval)
                        {
                            string row = "";
                            for(float x = 0; x < gif.Width; x += 2*interval)
                            {
                                if (chkBraille.Checked)
                                {
                                    int[] pixels = Braille.getPixels((int)x, (int)y, (int)interval, gif, (int)numThreshold.Value, (int)numAlpha.Value, chkInvert.Checked);
                                    row += Braille.getCharacter(pixels);
                                } else
                                {
                                    Color pix = gif.GetPixel((int)Math.Round(x, 0), (int)Math.Round(y, 0));
                                    int val = ((pix.R + pix.G + pix.B) / 3);
                                    row += val < 200 ? val < 150 ? val < 100 ? val < 50 ? "@@" : "##" : "//" : "++" : "  ";
                                }
                            }
                            rows[k] = row;
                            points[k] = k * f.Height;
                            SizeF size = g.MeasureString(row, f);
                            width = size.Width > width ? size.Width : width;
                            height += f.Height;

                            k++;
                        }
                        maxWidth = (int)width > maxWidth ? (int)width : maxWidth;
                        maxHeight = (int)height > maxHeight ? (int)height : maxHeight;

                        if (chkTextFile.Checked)
                        {
                            StreamWriter writer = new StreamWriter(path + "\\" + i.ToString() + ".txt");

                            for(int j = 0; j < rows.Length; j++)
                            {
                                writer.WriteLine(rows[j]);
                            }

                            writer.Close();
                            writer.Dispose();
                        } else
                        {
                            Bitmap frame = new Bitmap(maxWidth, maxHeight);

                            Graphics frameGraphics = Graphics.FromImage(frame);
                            frameGraphics.FillRectangle(new SolidBrush(Color.White), 0, 0, width, height);

                            for (int j = 0; j < rows.Length; j++)
                            {
                                string row = rows[j];
                                int y = points[j];

                                frameGraphics.DrawString(row, f, new SolidBrush(Color.Black), new PointF(0, y));
                            }
                            frame.Save(path + "\\" + i.ToString() + ".png");
                            frame.Dispose();
                            frameGraphics.Flush();
                            frameGraphics.Dispose();
                        }
                    }
                    lblConsole.Text = "Completed";
                }
            }
        }

        public static string ValueToBraille(int val)
        {
            string character = "  ";

            if(val < 33)
            {
                character = "⠿⠿";
            }
            else if (val < 70)
            {
                character = "⠽⠽";
            }
            else if (val < 107)
            {
                character = "⠗⠗";
            }
            else if (val < 144)
            {
                character = "⠕⠕";
            }
            else if (val < 181)
            {
                character = "⠅⠅";
            }
            else if(val < 218)
            {
                character = "⠁⠁";
            } else
            {
                character = "  ";
            }

            return character;
        }
    }
}
