using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    // Properties of the card
    public string cardName;          // Name of the card
    public string description;       // Description of the card's effect
    public int cost;                 // Mana or energy cost to play the card
    public Sprite artwork;           // Artwork for the card

    // UI References
    public Text nameText;            // Reference to the card's name text
    public Text descriptionText;     // Reference to the card's description text
    public Text costText;             // Reference to the card's cost text
    public Image artworkImage;  
    // Initialize the card with specific data
    public void Initialize(string name, string desc, int cardCost, Sprite art)
    {
        // Assign values to card properties
        cardName = name;
        description = desc;
        cost = cardCost;
        artwork = art;

        // Update the UI elements
        nameText.text = cardName;
        descriptionText.text = description;
        costText.text = cost.ToString();
        artworkImage.sprite = artwork;
    }

    // Action when the card is played
    public void PlayCard()
    {
        Debug.Log($"Playing card: {cardName}");
        // Add your logic here for what happens when the card is played
    }
    void Awake()
    {
        nameText = transform.Find("Name").GetComponent<Text>();
        artworkImage = transform.Find("Artwork").GetComponent<Image>();
    }
}
