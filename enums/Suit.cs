using System.ComponentModel.DataAnnotations;

namespace DeckOfCards.enums
{
    // enumeration of suit names
    public enum Suit
    {
        [Display(Name="Spades")]
        SPADES,

        [Display(Name="Hearts")]
        HEARTS,
        [Display(Name="Diamonds")]
        DIAMONDS,
        [Display(Name="Clubs")]
        CLUBS
    }
}