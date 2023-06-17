using AutoMapper;
using Entites;
using Entites.Models;
using Shared.DTOs;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace TraineAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            // Admin
            CreateMap<Admin, AdminDto>();

            CreateMap<AdminCreationDto, Admin>();

            CreateMap<AdminUpdateDto, Admin>();

            // Railway
            CreateMap<Railway, RailwayDto>();

            // TrainInStationTime 

            CreateMap<TrainInStationTime, TrainInStationTimeDto>();

            // Comment
            CreateMap<Comment, CommentDto>();

            CreateMap<Comment, ReturnedComment>();

            CreateMap<CommentDto, Comment>();

            CreateMap<CommentCreationDto, Comment>();

            CreateMap<CommentUpdateDto, Comment>();


            // LiveLocation
            CreateMap<LiveLocation, LiveLocationDto>();

            CreateMap<LiveLocation, FilterLocationDto>();
            CreateMap<LiveLocation, LatitudeDto>();

            CreateMap<LiveLocation, LongitudeDto>();

            CreateMap<LiveLocationDto, LiveLocation>();

            CreateMap<LiveLocationCreationDto, LiveLocation>();

            CreateMap<LiveLocationUpdateDto, LiveLocation>();

            //news
            
            CreateMap<News, NewsDto>();
            CreateMap<NewsCreateDto, News>();
            CreateMap<NewsUpdateDto, News>();

            //ticket
            CreateMap<Ticket, TicketDto>();
            CreateMap<Ticket, CheckIfScannOrNotDto>();
            CreateMap<CreateTicketDto, Ticket>();
            CreateMap<UpdateTicketDto, Ticket>();


            // Payment
            CreateMap<Payment, PaymentDto>();

            CreateMap<PaymentDto, Payment>();

            CreateMap<PaymentCreationDto, Payment>();

            CreateMap<PaymentUpdateDto, Payment>();

            // Post
            CreateMap<Post, PostDto>();

            CreateMap<PostDto, Post>();

            CreateMap<PostCreationDto, Post>();
            CreateMap<PostCreationDto, PostDto>();

            CreateMap<PostUpdateDto, Post>();

            // Report
            CreateMap<Report, ReportDto>();
            CreateMap<ReportDto, Report>();
            CreateMap<ReportCreationDto, Report>();
            CreateMap<ReportUpdateDto, Report>();

            //user
            CreateMap<User, userDto>();
            CreateMap<User, userTokenDTO>();
            CreateMap<User, DoctorDTO>();
            CreateMap<User, userloginDTO>();
            CreateMap<UserCreationDto, User>();
            CreateMap<UserUpdateDto, User>();

            

            //train
            CreateMap<Train, TrainDto>();
            CreateMap<Train, ConductorDto>();
            CreateMap<Train, DreiverDto>();
            CreateMap<TrainCreationDto,Train>();
            CreateMap<TrainUpdatenDto, Train>();

            //station
            CreateMap<Station, StationDto>();
            CreateMap<Station, StatioForOneTrainDto>();
            CreateMap<StationForCreateDto, Station>();
            CreateMap<StationForUpdateDto, Station>();

        }
    }
}
