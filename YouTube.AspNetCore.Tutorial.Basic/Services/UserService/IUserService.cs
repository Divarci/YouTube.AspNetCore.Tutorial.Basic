﻿using YouTube.AspNetCore.Tutorial.Basic.Models.Entity;
using YouTube.AspNetCore.Tutorial.Basic.Models.ViewModels.UserVM;

namespace YouTube.AspNetCore.Tutorial.Basic.Services.UserService
{
    public interface IUserService : IGenericService<User,UserListVM,UserCreateVM,UserUpdateVM>
    {
        new void CreateItem(UserCreateVM request);
        bool SignIn(string email, string propvidedPassword);
        void SignOut();
        new void UpdateItem(UserUpdateVM request);
    }
}
