﻿using GymManagmentBLL.ViewModels.MemberViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagmentBLL.Services.Interfaces
{
    public interface IMemberService
    {

        IEnumerable<MemberViewModel> GetAllMembers();

        bool CreateMember(CreatMemberViewModel creatMember);
    }
}
