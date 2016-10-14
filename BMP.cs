namespace HUtils.Imaging
  {
    class BMP
        {
            public int width;
            public int height;
            private int size;
            public bool Is24Bit(string filename)
            {
                byte[] Data = File.ReadAllBytes(filename);
                byte Bit = Data[0x1c];
                if (Bit == 0x18) { return true; } else { return false; }
                //return false;
            }
            public byte[] GetPixels(string filename)
            {
                byte[] Data = File.ReadAllBytes(filename);
                width = Data[18];
                height = Data[22];

                size = (width * 3 + 3) & (~3);

                byte[] data = new byte[size];
                Array.Copy(Data, data, size);
                for (int i = 0; i < size; i += 3)
                {
                    byte tmp = data[i];
                    data[i] = data[i + 2];
                    data[i + 2] = tmp;
                }
                return data;
            }
            public byte[] GetPixels(string filename, bool twentyfourbit)
            {
                byte[] Data = File.ReadAllBytes(filename);
                width = Data[18];
                height = Data[22];
                if (twentyfourbit)
                {
                    size = (width * 3 + 3) & (~3);
                }
                else
                {
                    size = 3 * width * height;
                }
                byte[] data = new byte[size];
                Array.Copy(Data, data, size);
                for (int i = 0; i < size; i += 3)
                {
                    byte tmp = data[i];
                    data[i] = data[i + 2];
                    data[i + 2] = tmp;
                }
                return data;
            }
            public byte[] GetPixels(byte[] Data)
            {

                width = Data[18];
                height = Data[22];

                size = (width * 3 + 3) & (~3);

                byte[] data = new byte[size];
                Array.Copy(Data, data, size);
                for (int i = 0; i < size; i += 3)
                {
                    byte tmp = data[i];
                    data[i] = data[i + 2];
                    data[i + 2] = tmp;
                }
                return data;
            }
            public byte[] GetPixels(byte[] Data, bool twentyfourbit)
            {

                width = Data[18];
                height = Data[22];
                if (twentyfourbit)
                {
                    size = (width * 3 + 3) & (~3);
                }
                else
                {
                    size = 3 * width * height;
                }
                byte[] data = new byte[size];
                Array.Copy(Data, data, size);
                for (int i = 0; i < size; i += 3)
                {
                    byte tmp = data[i];
                    data[i] = data[i + 2];
                    data[i + 2] = tmp;
                    //Debug.WriteLine(data[i]);
                }
                return data;
            }
        }
    }
  }
