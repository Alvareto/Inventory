using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Model;

namespace Inventory.Core
{
    public interface IMainFormController
    {
        void AddUser();
        void AddEquipment();
        void AddCategory();
        void AssignEquipment();
        void TransferEquipment();
        void DisposeEquipment();
        void DeactivateUser();
    }
}