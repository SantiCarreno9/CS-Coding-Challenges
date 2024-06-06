namespace TestDome;

public class Song
{
    private string name;
    public Song NextSong { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsInRepeatingPlaylist()
    {
        HashSet<Song> list = new HashSet<Song>();
        Song nextSong = this.NextSong;
        while (nextSong != null)
        {
            if(!list.Add(nextSong))
                return true;            
            nextSong = nextSong.NextSong;
        }
        return false;
    }

    //public static void Main(string[] args)
    //{
    //    Song first = new Song("Hello");
    //    Song second = new Song("Eye of the tiger");

    //    first.NextSong = second;
    //    second.NextSong = first;

    //    Console.WriteLine(first.IsInRepeatingPlaylist());
    //}
}