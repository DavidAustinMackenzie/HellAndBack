using System.Collections.ObjectModel;

namespace HellAndBack.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }

        public ObservableCollection<Card> Hand {  get; set; }
    }
}
