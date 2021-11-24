using AuthCrm.Data.DTOs;
using AuthCrm.Data.Models;
using AuthCrm.DataAccess.Abstruct;

namespace AuthCrm.Service.Abstract
{
    public interface IAdressService : IBaseService<AdressDto, Adress, IAdressDal>
    {
    }
}
