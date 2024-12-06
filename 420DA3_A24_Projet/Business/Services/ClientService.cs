using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ClientService {
    private readonly ProjetApplication _application;
    private readonly ClientDAO _dao;
    private readonly ClientView _view;

    public ClientService(ProjetApplication app, AppDbContext context) {
        _application = app ?? throw new ArgumentNullException(nameof(app));
        _dao = new ClientDAO(context);
        _view = new ClientView(app);
    }

    public Client? OpenViewFor(ViewActionsEnum viewAction, Client? client = null) {
        try {
            var result = _view.OpenFor(viewAction, client);
            if (result == DialogResult.OK) {
                switch (viewAction) {
                    case ViewActionsEnum.Creation:
                    case ViewActionsEnum.Edition:
                        _ = OpenViewFor(ViewActionsEnum.Visualization, _view.GetCurrentInstance());
                        break;
                    default:
                        break;
                }
            }

            return _view.GetCurrentInstance();
        } catch (Exception ex) {
            _application.HandleException(ex);
            return null;
        }
    }

    public List<Client> Search(string filter) {
        try {
            return _dao.Search(filter);
        } catch (Exception ex) {
            throw new Exception("Failed to search for [Client] instances.", ex);
        }
    }

    public Client Create(Client newClient) {
        try {
            return _dao.Create(newClient);
        } catch (Exception ex) {
            throw new Exception("Failed to create new [Client].", ex);
        }
    }

    public Client? GetById(int id) {
        try {
            return _dao.GetById(id);
        } catch (Exception ex) {
            throw new Exception($"Failed to obtain [Client] instance with id# {id}.", ex);
        }
    }

    public Client Update(Client client) {
        try {
            return _dao.Update(client);
        } catch (Exception ex) {
            throw new Exception($"Failed to update [Client] instance with id# {client.Id}.", ex);
        }
    }

    public void Delete(Client client, bool softDeletes = true) {
        try {
            _dao.Delete(client, softDeletes);
        } catch (Exception ex) {
            throw new Exception($"Failed to delete [Client] instance with id# {client.Id}.", ex);
        }
    }
}

