using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSys
{
    class Club
    {
        private string clubName;
        private string clubDescription, clubPresident, clubVice, clubSecretary, clubSecretaryID;
        private string clubEstablished;

        public string ClubName { get => clubName; set => clubName = value; }
        public string ClubDescription { get => clubDescription; set => clubDescription = value; }
        public string ClubPresident { get => clubPresident; set => clubPresident = value; }
        public string ClubVice { get => clubVice; set => clubVice = value; }
        public string ClubSecretary { get => clubSecretary; set => clubSecretary = value; }
        public string ClubSecretaryID { get => clubSecretaryID; set => clubSecretaryID = value; }
        public string ClubEstablished { get => clubEstablished; set => clubEstablished = value; }

        //Constructor for all Club attributes
        public Club(string clubName, string clubDescription, string clubPresident, string clubVice, string clubSecretary, string clubSecretaryID, string clubEstablished)
        {
            this.ClubName = clubName;
            this.ClubDescription = clubDescription;
            this.ClubPresident = clubPresident;
            this.ClubVice = clubVice;
            this.ClubSecretary = clubSecretary;
            this.ClubSecretaryID = clubSecretaryID;
            this.ClubEstablished = clubEstablished;
        }

        //Constructor for all Club attributes except DateEstablished. Used to edit club
        public Club(string clubName, string clubDescription, string clubPresident, string clubVice, string clubSecretary, string clubSecretaryID)
        {
            this.ClubName = clubName;
            this.ClubDescription = clubDescription;
            this.ClubPresident = clubPresident;
            this.ClubVice = clubVice;
            this.ClubSecretary = clubSecretary;
            this.ClubSecretaryID = clubSecretaryID;
        }
    }
}
