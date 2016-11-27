using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class DropDownList : MonoBehaviour {

	List<string> Countries = new List<string> {"Afghanistan", "Afrique du Sud", "Albanie", "Algérie", "Allemagne", "Andorre", "Angola", "Antigua-et-Barbuda",
		"Arabie saoudite", "Argentine", "Arménie", "Australie", "Autriche", "Azerbaïdjan", "Bahamas", "Bahreïn", "Bangladesh",
		"Barbade", "Bélarus", "Belgique", "Belize", "Bénin", "Bhoutan", "Bolivie", "Bosnie-Herzégovine", "Botswana", "Brésil",
		"Brunéi Darussalam", "Bulgarie", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodge", "Cameroun", "Canada", "Chili", "Chine",
		"Chypre", "Colombie", "Comores", "Congo", "Costa Rica", "Côte d'Ivoire", "Croatie", "Cuba", "Danemark", "Djibouti", "Dominique",
		"Égypte", "El Salvador", "Émirats arabes unis", "Équateur", "Érythrée", "Espagne", "Estonie", "États-Unis d'Amérique", "Éthiopie", "Fidji",
		"Finlande", "France", "Gabon", "Gambie", "Géorgie", "Ghana", "Grèce", "Grenade", "Guatemala", "Guinée", "Guinée équatoriale",
		"Guinée-Bissau", "Guyana", "Haïti", "Honduras", "Hongrie", "Îles Cook", "Îles Marshall", "Îles Salomon", "Inde", "Indonésie",
		"Iran", "Iraq", "Irlande", "Islande", "Israël", "Italie", "Jamaïque", "Japon", "Jordanie", "Kazakhstan", "Kenya", "Kirghizistan",
		"Kiribati", "Koweït", "Lesotho", "Lettonie", "Liban", "Libéria", "Libye", "Lituanie", "Luxembourg", "Madagascar", "Malaisie",
		"Malawi", "Maldives", "Mali", "Malte", "Maroc", "Maurice", "Mauritanie", "Mexique", "Micronésie", "Monaco", "Mongolie",
		"Monténégro", "Mozambique", "Myanmar", "Namibie", "Nauru", "Népal", "Nicaragua", "Niger", "Nigéria", "Nioué", "Norvège",
		"Nouvelle-Zélande", "Oman", "Ouganda", "Ouzbékistan", "Pakistan", "Palaos", "Palestine", "Panama",
		"Papouasie-Nouvelle-Guinée", "Paraguay", "Pays-Bas", "Pérou", "Philippines", "Pologne", "Portugal", "Qatar",
		"République dominicaine", "Roumanie", "Royaume-Uni", "Russie", "Rwanda", "Sainte-Lucie", "Saint-Kitts-et-Nevis",
		"Saint-Marin", "Saint-Vincent-et-les Grenadines", "Samoa", "Sao Tomé-et-Principe", "Sénégal", "Serbie", "Seychelles",
		"Sierra Leone", "Singapour", "Slovaquie", "Slovénie", "Somalie", "Soudan", "Soudan du Sud", "Sri Lanka", "Suède", "Suisse",
		"Suriname", "Swaziland", "Tadjikistan", "Tanzanie", "Tchad", "Tchéquie", "Thaïlande", "Timor-Leste", "Togo", "Tonga",
		"Trinité-et-Tobago", "Tunisie", "Turkménistan", "Turquie", "Tuvalu", "Ukraine", "Uruguay", "Vanuatu", "Venezuela", "Viet Nam",
		"Yémen", "Zambie", "Zimbabwe"};

	public Dropdown dropdown;
	public string selectedCountry;

	void Start () {
		ListCountries ();
	}

	void ListCountries () {
		dropdown.AddOptions(Countries);
		dropdown.captionText.text = "Pays";
	}

	public void DropdownSelection(int index) {
		selectedCountry = Countries[index];
		Debug.Log (selectedCountry);
	}
		
}
