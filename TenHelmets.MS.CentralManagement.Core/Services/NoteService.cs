namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class NoteService : BaseService<Note>, INoteService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="noteRepository"></param>
        public NoteService(INoteRepository noteRepository)
            : base(noteRepository)
        {

        }
    }
}
