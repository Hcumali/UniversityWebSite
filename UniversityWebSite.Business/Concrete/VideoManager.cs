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
    public class VideoManager : IVideoService
    {
        IVideoRepository _videoRepository;

        public VideoManager(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        public IEnumerable<Video> GetAllVideo()
        {
            return _videoRepository.GetAll();
        }

        public void UpdateVideo(Video video)
        {
            _videoRepository.Update(video);
        }
    }
}
