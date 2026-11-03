
using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IchatLieuRepositories
    {
        List<chatLieu> GetchatLieuFromDB();
        bool addchatLieu(chatLieu ChatLieu);
        bool RemovechatLieu(chatLieu ChatLieu);
        bool UpdatechatLieu(chatLieu ChatLieu);

    }
}
