﻿using System;
using d60.Cirqus.Events;

namespace Oditel.Cirqus.Models.BookingContext.Events
{
    public class BookingRoomAddedEvent : DomainEvent<Booking>
    {
        public BookingRoomAddedEvent(Guid roomId, DateTimeOffset checkInDate)
        {
            RoomId = roomId;
            CheckInDate = checkInDate;
        }

        public Guid RoomId { get; }
        public DateTimeOffset CheckInDate { get; }
    }
}