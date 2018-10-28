using MohatechDAL.Classes;
using MohatechDAL.Interfaces;
using System;

namespace MohatechDAL.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private readonly DataContext _context = new DataContext();

        private ISettingDal _settingDal;
        public ISettingDal SettingDal
        {
            get
            {
                if (_settingDal == null)
                {
                    _settingDal = new SettingDal(_context);
                }

                return _settingDal;
            }
        }

        private IRoleDal _roleDal;
        public IRoleDal RoleDal
        {
            get
            {
                if (_roleDal == null)
                {
                    _roleDal = new RoleDal(_context);
                }

                return _roleDal;
            }
        }

        private IUserDal _userDal;
        public IUserDal UserDal
        {
            get
            {
                if (_userDal == null)
                {
                    _userDal = new UserDal(_context);
                }

                return _userDal;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
