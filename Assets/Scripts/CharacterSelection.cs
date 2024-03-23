using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characterPrefabs; // Array of character prefabs
    public Transform spawnPoint; // Spawn point for instantiating characters
    public TextMeshProUGUI characterNameText; // TextMeshProUGUI element to display character name

    private GameObject currentCharacter; // Reference to the currently selected character
    private int selectedCharacterIndex = 0; // Index of the currently selected character

    void Start()
    {
        // Initialize character selection with the first character
        SelectCharacter(selectedCharacterIndex);
    }

    // Method called when the player selects a character
    public void SelectCharacter(int characterIndex)
    {
        selectedCharacterIndex = characterIndex;

        // Destroy the current character if it exists
        if (currentCharacter != null)
        {
            Destroy(currentCharacter);
        }

        // Instantiate the selected character prefab at the spawn point
        currentCharacter = Instantiate(characterPrefabs[characterIndex], spawnPoint.position, Quaternion.identity);

        // Update the character name text
        characterNameText.text = characterPrefabs[characterIndex].name;
    }

    // Button click event handler for selecting the next character
    public void OnCharacterNextButtonClick()
    {
        selectedCharacterIndex++;
        if (selectedCharacterIndex >= characterPrefabs.Length)
        {
            selectedCharacterIndex = 0;
        }
        SelectCharacter(selectedCharacterIndex);
    }

    // Button click event handler for selecting the previous character
    public void OnCharacterBackButtonClick()
    {
        selectedCharacterIndex--;
        if (selectedCharacterIndex < 0)
        {
            selectedCharacterIndex = characterPrefabs.Length - 1;
        }
        SelectCharacter(selectedCharacterIndex);
    }
}
