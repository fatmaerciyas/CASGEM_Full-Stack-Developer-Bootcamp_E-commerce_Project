using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Concrete
{
    public class OurTeamManager : IOurTeamService
    {
        private readonly IOurTeamDal _OurTeamDal;

        public OurTeamManager(IOurTeamDal OurTeamDal)
        {
            _OurTeamDal = OurTeamDal;
        }

        public void TDelete(OurTeam t)
        {
            _OurTeamDal.Delete(t);
        }

        public OurTeam TGetByID(int id)
        {
            var OurTeam = _OurTeamDal.GetByID(id);
            return OurTeam;
        }

        public List<OurTeam> TGetList()
        {
            var categories = _OurTeamDal.GetList();
            return categories;
        }

        public void TInsert(OurTeam t)
        {
            _OurTeamDal.Insert(t);
        }

        public void TUpdate(OurTeam t)
        {
            _OurTeamDal.Update(t);
        }
    }
}
