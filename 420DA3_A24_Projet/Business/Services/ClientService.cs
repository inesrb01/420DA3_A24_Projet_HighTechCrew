using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services {
    internal class ClientService {
        private WsysApplication parentApp;
        private ClientDAO dao;
        private ClientView view;
        private AppDbContext context;

        public ClientService(WsysApplication application, AppDbContext contexte) {
            this.parentApp = application ?? throw new ArgumentNullException(nameof(application)); 
            this.context = contexte ?? throw new ArgumentNullException(nameof(contexte));         
            this.dao = new ClientDAO(context);
            this.view = new ClientView(parentApp);
        }

        /// <summary>
        /// Crée un nouveau client.
        /// </summary>
        public Client CreateClient(Client client) {
            try {
                return dao.Create(client);
            } catch (Exception ex) {
                throw new Exception("Erreur lors de la création du client.", ex);
            }
        }

        /// <summary>
        /// Recherche des clients par mot-clé.
        /// </summary>
        public List<Client> Search(string keyword) {
            try {
                return dao.Search(keyword);
            } catch (Exception ex) {
                throw new Exception("Erreur lors de la recherche de clients.", ex);
            }
        }

        /// <summary>
        /// Met à jour un client existant.
        /// </summary>
        public Client Update(Client client) {
            try {
                return dao.Update(client);
            } catch (Exception ex) {
                throw new Exception("Erreur lors de la mise à jour du client.", ex);
            }
        }

        /// <summary>
        /// Supprime un client.
        /// </summary>
        public void Delete(Client client, bool hardDelete = true) {
            try {
                dao.Delete(client, hardDelete);
            } catch (Exception ex) {
                throw new Exception("Erreur lors de la suppression du client.", ex);
            }
        }

        /// <summary>
        /// Récupère un client par ID.
        /// </summary>
        public Client? GetById(int id) {
            try {
                return dao.GetById(id);
            } catch (Exception ex) {
                throw new Exception($"Erreur lors de la récupération du client avec l'ID {id}.", ex);
            }
        }
    }
}
