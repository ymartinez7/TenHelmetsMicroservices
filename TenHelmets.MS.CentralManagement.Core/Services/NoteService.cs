using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class NoteService : BaseService<Note>, INoteService
    {
        public NoteService(INoteRepository noteRepository)
            : base(noteRepository)
        {

        }
    }
}
