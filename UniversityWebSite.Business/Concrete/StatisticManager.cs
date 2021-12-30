using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.DataAccess.Abstract.Repositories;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.Business.Concrete
{
    public class StatisticManager : IStatisticService
    {
        IStatisticRepository _statisticRepository;

        public StatisticManager(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public IEnumerable<Statistic> GetAllStatistic()
        {
            return _statisticRepository.GetAll();
        }

        public void UpdateStatistic(Statistic statistic)
        {
            _statisticRepository.Update(statistic);
        }
    }
}
