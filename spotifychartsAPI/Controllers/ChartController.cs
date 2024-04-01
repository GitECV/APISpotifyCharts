using Microsoft.AspNetCore.Mvc;
using spotifychartsAPI.Models;
using spotifychartsAPI.Requests;

namespace spotifychartsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public ChartController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost("/getPlaylistDatetime")]
        public ActionResult<List<Charts>> GetPlaylistDatetimeCharts([FromBody] ItemDatetimeRequest request)
        {
            return Ok(_dataContext.GlobalDailyChart.Where(g => g.sPlaylist == request.Playlist && g.dtDatetime == request.Date).ToList());
        }

        [HttpPost("/getSongDatetime")]
        public ActionResult<List<Charts>> GetSongDatetimeCharts([FromBody] ItemDatetimeRequest request)
        {
            return Ok(_dataContext.GlobalDailyChart.Where(g => g.sSongName == request.Item && g.dtDatetime == request.Date
            && g.sPlaylist == request.Playlist).ToList());
        }

        [HttpPost("/getPositionDatetime")]
        public ActionResult<List<Charts>> GetPositionDatetimeCharts([FromBody] ItemDatetimeRequest request)
        {
            return Ok(_dataContext.GlobalDailyChart.Where(g => g.iChartPosition == Int32.Parse(request.Item) && g.dtDatetime == request.Date
            && g.sPlaylist == request.Playlist).ToList());
        }

        [HttpPost("/getArtistDatetime")]
        public ActionResult<List<Charts>> GetArtistDatetimeCharts([FromBody] ItemDatetimeRequest request)
        {
            return Ok(_dataContext.GlobalDailyChart.Where(g => g.sArtistName == request.Item && g.dtDatetime == request.Date
            && g.sPlaylist == request.Playlist).ToList());
        }

        [HttpPost("/getArtistDatetimeAllPlaylists")]
        public ActionResult<List<Charts>> GetArtistDatetimeAllPlaylistsCharts([FromBody] ItemDatetimeRequest request)
        {
            return Ok(_dataContext.GlobalDailyChart.Where(g => g.sArtistName == request.Item && g.dtDatetime == request.Date).ToList());
        }

        [HttpPost("/getSongDatetimeAllPlaylists")]
        public ActionResult<List<Charts>> GetSongDatetimeAllPlaylistsCharts([FromBody] ItemDatetimeRequest request)
        {
            return Ok(_dataContext.GlobalDailyChart.Where(g => g.sSongName == request.Item && g.dtDatetime == request.Date).ToList());
        }

        [HttpPost("/getPlaylistDatetimeRange")]
        public ActionResult<List<Charts>> GetPlaylistDatetimeRange([FromBody] ItemDatetimeRangeRequest request)
        {
            return Ok(_dataContext.GlobalDailyChart.Where(g => g.sPlaylist == request.Item && g.dtDatetime >= request.StartDate && g.dtDatetime <= request.EndDate).ToList());
        }

        [HttpPost("/getSongDatetimeRange")]
        public ActionResult<List<Charts>> GetSongDatetimeRange([FromBody] ItemDatetimeRangeRequest request)
        {
            return Ok(_dataContext.GlobalDailyChart.Where(g => g.sSongName == request.Item && g.dtDatetime >= request.StartDate && g.dtDatetime <= request.EndDate).ToList());
        }

        [HttpPost("/getPositionDatetimeRange")]
        public ActionResult<List<Charts>> GetPositionDatetimeRange([FromBody] ItemDatetimeRangeRequest request)
        {
            return Ok(_dataContext.GlobalDailyChart.Where(g => g.iChartPosition == Int32.Parse(request.Item) && g.dtDatetime >= request.StartDate && g.dtDatetime <= request.EndDate).ToList());
        }

        [HttpPost("/getArtistDatetimeRange")]
        public ActionResult<List<Charts>> getArtistDatetimeRange([FromBody] ItemDatetimeRangeRequest request)
        {
            return Ok(_dataContext.GlobalDailyChart.Where(g => g.sArtistName == request.Item && g.dtDatetime >= request.StartDate && g.dtDatetime <= request.EndDate).ToList());
        }
    }
}
