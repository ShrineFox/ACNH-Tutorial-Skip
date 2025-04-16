namespace CombineEVFL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txtPath = "C:\\Users\\Ryan\\Documents\\GitHub\\ACNH-Tutorial-Skip\\_Docs\\item_id_list_formatted.txt";

            string[] lines = File.ReadAllLines(txtPath);
            List<string> pages = new List<string>();
            string pageTxt = "";

            int counter = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (counter < 1400)
                {
                    pageTxt += "\r\n" + lines[i];
                    counter++;
                }
                else
                {
                    pages.Add(pageTxt);
                    pageTxt = "\r\n" + lines[i];
                    counter = 0;
                }
            }

            int pageNo = 0;
            foreach (var page in pages)
            {
                File.WriteAllText($"Mod_UnlockCatalogItems_{pageNo}.evfl", "flow Root():" + page);
                pageNo++;
            }
        }
    }
}
