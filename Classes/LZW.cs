using System;
using System.Collections.Generic;

namespace LZWAlgorithms
{
    public class LZW
    {
        private static List<ushort> Xor(List<ushort> data, string key)
        {
            var xorKey = key.GetHashCode();

            for (int i = 0; i < data.Count; i++)
            {
                data[i] = (ushort)(data[i] ^ xorKey);
            }

            return data;
        }

        public static List<ushort> Compress(byte[] input, string key)
        {
            Dictionary<string, uint> dictionary = ANSI.Table;

            string current = string.Empty;
            List<ushort> compressed = new List<ushort>();
            uint dictSize = (uint)dictionary.Count;

            foreach (byte b in input)
            {
                string combined = current + (char)b;
                if (dictionary.ContainsKey(combined))
                {
                    current = combined;
                }
                else
                {
                    compressed.Add((ushort)dictionary[current]);
                    if (dictSize < ushort.MaxValue)
                        dictionary.Add(combined, dictSize++);
                    current = ((char)b).ToString();
                }
            }

            if (!string.IsNullOrEmpty(current))
            {
                compressed.Add((ushort)dictionary[current]);
            }

            return key == "" ? compressed : Xor(compressed, key);
        }


        public static byte[] Decompress(List<ushort> compressed, string key)
        {
            if (key != "") compressed = Xor(compressed, key);

            Dictionary<uint, string> dictionary = ANSI.TableReversed;

            uint dictSize = (uint)dictionary.Count;

            string previous = dictionary[compressed[0]];
            List<byte> decompressed = new List<byte>(previous.Length);
            foreach (char c in previous)
            {
                decompressed.Add((byte)c);
            }

            for (int i = 1; i < compressed.Count; i++)
            {
                string entry;
                if (dictionary.ContainsKey(compressed[i]))
                {
                    entry = dictionary[compressed[i]];
                }
                else if (compressed[i] == dictSize)
                {
                    entry = previous + previous[0];
                }
                else
                {
                    throw new ArgumentException("Invalid compressed code.");
                }

                foreach (char c in entry)
                {
                    decompressed.Add((byte)c);
                }

                if (dictSize < ushort.MaxValue)
                    dictionary.Add(dictSize++, previous + entry[0]);

                previous = entry;
            }

            return decompressed.ToArray();
        }

    }
}
