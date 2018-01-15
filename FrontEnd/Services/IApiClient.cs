using ConferenceDTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontEnd.Services
{
    public interface IApiClient
    {
        Task<IList<SessionResponse>> GetSessionsAsync();
        Task<SessionResponse> GetSessionAsync(int id);
        Task<IList<SpeakerResponse>> GetSpeakersAsync();
        Task<SpeakerResponse> GetSpeakerAsync(int id);
        Task PutSessionAsync(Session session);
        //Task<IList<SearchResult>> SearchAsync(string query);
        Task AddAttendeeAsync(Attendee attendee);
        Task<AttendeeResponse> GetAttendeeAsync(string name);
        Task DeleteSessionAsync(int id);
    }
}
