using System.Threading.Tasks;

namespace MvvmLightWin81.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}