using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.Save
{
    class SaveVillage
    {
        Village vill;
        public SaveVillage(Village vill)
        {
            this.vill = vill;
        }

        public void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "*.aov";
            sfd.Filter = "AoV file(*.aov)| *.aov";
            sfd.DefaultExt = "aov";
            sfd.Title = "Save an aov File";
            sfd.InitialDirectory = @"H:\aov_saved\";
            sfd.RestoreDirectory = true;
            sfd.ShowDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = sfd.OpenFile();
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(sw, vill);
                    sw.Close();
                }
                fileStream.Close();
            }
        }




    }
}
