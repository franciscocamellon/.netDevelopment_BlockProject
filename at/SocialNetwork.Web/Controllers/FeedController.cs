using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Interfaces.Repositories;
using System.Threading.Tasks;

namespace SocialNetwork.Web.Controllers
{
    public class FeedController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IProfileRepository _profileRepository;
        private readonly IPostRepository _postRepository;
        public FeedController(UserManager<User> userManager, 
                              IProfileRepository profileRepository,
                              IPostRepository postRepository)
        {
            _userManager = userManager;
            _profileRepository = profileRepository;
            _postRepository = postRepository;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var posts = await _postRepository.GetLastPostsAsync();

            return View(posts);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> OnInsertPost([FromForm] Post post)
        {
            //recuperando user completo do banco de dados
            var currentUserId = _userManager.GetUserId(User);

            //obter a entidade perfil
            var profileFromBd = await _profileRepository.GetProfileByUserIdAsync(currentUserId);

            //atribuindo o profile do usuário logado no post
            post.Profile = profileFromBd;

            //inserindo no banco de dados
            await _postRepository.InsertAsync(post);

            return RedirectToAction(nameof(Index));
        }
    }
}
