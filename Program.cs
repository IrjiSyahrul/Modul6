using modul6_1302220088;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Ucok");
        String[] judul = new string[]
        {
            "Tutorial Java", 
            "Upin Ipin",
            "Tukang bubur naik HAJI",
            "Boboboy",
            "Dana",
            "Log in",
            "Pod Cast",
            "Prank",
            "Jess no limit comeback",
            "Onic kalah",
        };
        for(int i = 0; i < judul.Length; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo("Review Film  " + judul[i] + " oleh " + user.GetUsername());
            video.IncreasePlaycount(100);
            Console.WriteLine("Menambahkan film : ");
            video.PrintVideoDetails();
            user.addVideo(video);
        }

        user.PrintAllVideoPlayCount();
        user.GetTotalVideoPlaycount();
    }
}