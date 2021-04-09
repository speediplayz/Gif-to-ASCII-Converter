using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleText
{
    public static class Braille
    {
        private static List<string> keys = new List<string>()
        {
            "000000",
            "000010",
            "001000",
            "100000",
            "000001",
            "000100",
            "010000",
            "101000",
            "100010",
            "110000",
            "100100",
            "100001",
            "001010",
            "011000",
            "001100",
            "001001",
            "010010",
            "000110",
            "000011",
            "010100",
            "010001",
            "000101",
            "101010",
            "111000",
            "110010",
            "011010",
            "101100",
            "100110",
            "001110",
            "110100",
            "011100",
            "010110",
            "101001",
            "100011",
            "001011",
            "110001",
            "011001",
            "010011",
            "100101",
            "001101",
            "000111",
            "010101",
            "111010",
            "101110",
            "111100",
            "110110",
            "011110",
            "101011",
            "111001",
            "110011",
            "011011",
            "101101",
            "100111",
            "001111",
            "110101",
            "011101",
            "010111",
            "111110",
            "111011",
            "101111",
            "111101",
            "110111",
            "011111",
            "111111"
        };

        private static List<string> values = new List<string>()
        {
            "⠄",
            "⠄",
            "⠂",
            "⠁",
            "⠠",
            "⠐",
            "⠈",
            "⠃",
            "⠅",
            "⠉",
            "⠑",
            "⠡",
            "⠆",
            "⠊",
            "⠒",
            "⠢",
            "⠌",
            "⠔",
            "⠤",
            "⠘",
            "⠨",
            "⠰",
            "⠇",
            "⠋",
            "⠍",
            "⠎",
            "⠓",
            "⠕",
            "⠖",
            "⠙",
            "⠚",
            "⠜",
            "⠣",
            "⠥",
            "⠦",
            "⠩",
            "⠪",
            "⠬",
            "⠱",
            "⠲",
            "⠴",
            "⠸",
            "⠏",
            "⠗",
            "⠛",
            "⠝",
            "⠞",
            "⠧",
            "⠫",
            "⠭",
            "⠮",
            "⠳",
            "⠵",
            "⠶",
            "⠹",
            "⠺",
            "⠼",
            "⠟",
            "⠯",
            "⠷",
            "⠻",
            "⠽",
            "⠾",
            "⠿"
        };

        public static int[] getPixels(int x, int y, int increment, Bitmap image, int threshold, int alphaMin, bool invert)
        {
            int[] pixels = new int[6];
            if (invert)
            {
                pixels[0] = average(getPixel(image, x + 0 * increment, y + 0 * increment, invert), alphaMin, invert) <= threshold ? 0 : 1;
                pixels[1] = average(getPixel(image, x + 1 * increment, y + 0 * increment, invert), alphaMin, invert) <= threshold ? 0 : 1;
                pixels[2] = average(getPixel(image, x + 0 * increment, y + 1 * increment, invert), alphaMin, invert) <= threshold ? 0 : 1;
                pixels[3] = average(getPixel(image, x + 1 * increment, y + 1 * increment, invert), alphaMin, invert) <= threshold ? 0 : 1;
                pixels[4] = average(getPixel(image, x + 0 * increment, y + 2 * increment, invert), alphaMin, invert) <= threshold ? 0 : 1;
                pixels[5] = average(getPixel(image, x + 1 * increment, y + 2 * increment, invert), alphaMin, invert) <= threshold ? 0 : 1;
            }
            else
            {
                pixels[0] = average(getPixel(image, x + 0 * increment, y + 0 * increment, invert), alphaMin, invert) >= threshold ? 0 : 1;
                pixels[1] = average(getPixel(image, x + 1 * increment, y + 0 * increment, invert), alphaMin, invert) >= threshold ? 0 : 1;
                pixels[2] = average(getPixel(image, x + 0 * increment, y + 1 * increment, invert), alphaMin, invert) >= threshold ? 0 : 1;
                pixels[3] = average(getPixel(image, x + 1 * increment, y + 1 * increment, invert), alphaMin, invert) >= threshold ? 0 : 1;
                pixels[4] = average(getPixel(image, x + 0 * increment, y + 2 * increment, invert), alphaMin, invert) >= threshold ? 0 : 1;
                pixels[5] = average(getPixel(image, x + 1 * increment, y + 2 * increment, invert), alphaMin, invert) >= threshold ? 0 : 1;
            }

            return pixels;
        }

        public static string getCharacter(int[] pixels)
        {
            string key = (pixels[0].ToString() + pixels[1].ToString() + pixels[2].ToString() + pixels[3].ToString() + pixels[4].ToString() + pixels[5].ToString());
            int index = keys.IndexOf(key);
            return values[index];
        }

        private static Color getPixel(Bitmap img, int x, int y, bool invert)
        {
            if (x >= img.Width || y >= img.Height) return invert ? Color.Black : Color.White;
            return img.GetPixel(x, y);
        }

        private static int average(Color c, int alphaMin, bool invert)
        {
            if (c.A < alphaMin) return invert ? 0 : 255;
            return (c.R + c.G + c.B) / 3;
        }
    }
}
