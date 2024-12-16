using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Business.Services;
internal class WarehouseService {
    private readonly ProjetApplication _application;
    private readonly WarehouseDAO _dao;
    private readonly WarehouseView _view;

    public WarehouseService(ProjetApplication app, AppDbContext context) {
        _application = app ?? throw new ArgumentNullException(nameof(app));
        _dao = new WarehouseDAO(context);
    }

    public Warehouse? OpenViewFor(ViewActionsEnum viewAction, Warehouse? warehouse = null) {
        try {
            DialogResult result = _view.OpenFor(viewAction, warehouse);
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

    public List<Warehouse> Search(string filter) {
        try {
            return _dao.Search(filter);
        } catch (Exception ex) {
            throw new Exception("Failed to search for [Warehouse] instances.", ex);
        }
    }

    public Warehouse Create(Warehouse newWarehouse) {
        try {
            return _dao.Create(newWarehouse);
        } catch (Exception ex) {
            throw new Exception("Failed to create new [Warehouse].", ex);
        }
    }

    public Warehouse? GetById(int id) {
        try {
            return _dao.GetById(id);
        } catch (Exception ex) {
            throw new Exception($"Failed to obtain [Warehouse] instance with id# {id}.", ex);
        }
    }

    public Warehouse Update(Warehouse warehouse) {
        try {
            return _dao.Update(warehouse);
        } catch (Exception ex) {
            throw new Exception($"Failed to update [Warehouse] instance with id# {warehouse.Id}.", ex);
        }
    }

    public void Delete(Warehouse warehouse, bool softDeletes = true) {
        try {
            _dao.Delete(warehouse, softDeletes);
        } catch (Exception ex) {
            throw new Exception($"Failed to delete [Warehouse] instance with id# {warehouse.Id}.", ex);
        }
    }
}

