﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edu_core_app.Contracts.V1
{
    public static class ApiRoutes
    {
        private const string Root = "api";
        private const string Version = "v1";
        private const string Base = Root + "/" + Version;
        public static class Posts
        {
            public const string GetAll = Base + "/posts"; 
            public const string Get = Base + "/posts/{postId}"; 
            public const string Update = Base + "/posts/{postId}"; 
            public const string Delete = Base + "/posts/{postId}"; 
            public const string Create = Base + "/posts"; 
        }

        public static class Identity
        {
            public const string Register = Base + "/identity/register";
            public const string Login = Base + "/identity/login";
        }
    }
}