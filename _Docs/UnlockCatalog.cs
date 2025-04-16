namespace CombineEVFL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txtPath = "C:\\Users\\Ryan\\Documents\\GitHub\\ACNH-Tutorial-Skip\\_Docs\\item_id_list.txt";
            string txt = "";
            foreach (var line in File.ReadAllLines(txtPath))
            {
                var splitLine = line.Split('\t');
                txt += $"\r\n\tEventFlowSystemActor.SetItemToPocket({Convert.ToInt32(splitLine[2], 16)}, 1)  # {splitLine[0]}\r\n\tMainNpc.SetDeliveryItemAtRandom({Convert.ToInt32(splitLine[2], 16)}, false, 'cVillageRemakePattern', 0)\r\n\tEventFlowSystemActor.DeleteTargetItem({Convert.ToInt32(splitLine[2], 16)}, 1, false)";
            }
            File.WriteAllText("txt.txt", txt);
        }
    }
}
