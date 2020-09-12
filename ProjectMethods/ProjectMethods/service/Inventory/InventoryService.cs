using ProjectMethods.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMethods.service
{
    interface InventoryService
    {
        void addTicket(Ticket ticket, UserData user);
        void deleteTicket(Ticket ticket, UserData user);
    }
}
