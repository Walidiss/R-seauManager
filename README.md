Gestionnaire de Réseau (LAN/WiFi) – Application WinForms + WCF
📌 Description
Ce projet est une application de gestion de réseaux (LAN/WiFi) développée en C# avec WinForms côté client et WCF côté service.
Elle permet de récupérer et d’afficher la liste des adaptateurs réseau installés sur un poste client, avec leurs informations principales (nom, type, statut, etc.).

🏗️ Architecture
Client (WinForms) : Interface graphique permettant d’interagir avec le service.

Service (WCF) : Fournit les méthodes permettant de lister les adaptateurs réseau.

Communication : via HTTP (BasicHttpBinding)

⚙️ Technologies utilisées
.NET Framework (4.8)

C#

WinForms

WCF (Windows Communication Foundation)

Visual Studio

XML / SOAP

📂 Structure du projet
lua
Copier
Modifier
/NetworkManager
├── NetworkClient        --> Application WinForms
├── NetworkService       --> Interface WCF + classes partagées
├── NetworkHost          --> Projet Console pour héberger le service WCF
▶️ Instructions pour lancer le projet
1. Démarrer le service WCF (NetworkHost)
Ouvrir le projet NetworkHost

Lancer l’application (F5)

Le service démarre sur http://localhost:5000/NetworkService

🔁 Laisser la console ouverte pendant l'exécution

2. Ajouter la référence de service dans NetworkClient
Clic droit sur NetworkClient > Ajouter > Référence de service

Adresse : http://localhost:5000/NetworkService

Espace de nom : NetworkRef

Cliquer sur OK

3. Lancer l’application cliente
Ouvrir NetworkClient

Exécuter (F5)

Cliquer sur le bouton “Lister” pour afficher les adaptateurs réseau

🧪 Exemple de code (client)
csharp
Copier
Modifier
private void btnLister_Click(object sender, EventArgs e)
{
    var client = new NetworkRef.NetworkServiceClient();
    var adapters = client.GetNetworkAdapters();
    
    gridAdapters.AutoGenerateColumns = true;
    gridAdapters.DataSource = adapters;
}
🔐 Sécurité
Ce projet est destiné à un usage interne.

Pas d’authentification pour le moment (peut être ajouté via un CustomBehavior WCF).

📌 À faire
 Ajouter des détails pour chaque adaptateur (IP, MAC, vitesse…)

 Rafraîchissement automatique

 Export des données en CSV

 Interface plus moderne (WPF ?)

