//Reed Goodwin
//10-27-2022
//Magic 8 Ball!
//Peer reviewed by Harrison Busby: I really liked the code. His responses were hilariously mean. I enjoyed how organized his code is and the way he formatted his responses was different than mine. Overall great work Reed! :)

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GoodwinR_Magic8ball.Controllers
{
    [Route("[controller]")]
    public class Magic : Controller
    {
        [HttpGet]
        [Route("8Ball")]
        public string shake(){
            Random num = new Random();
            int den = num.Next(0,8);
            int l = num.Next(0,3);
            string[] deez = {"Not good","Bad OutLook","Just Give Up", "Your No Good", "I see All", "You are in danger... Its from me", "You should see a therapist", "I have no faith in you", "All of that for nothing" };
            string[] walkingl = {"Thats gotta hurt...", "are you gonna cry about it?", "yeah thats about right", "I think the 8ball is correct!"};
            return $"Welcome to Reed Magic 8 Ball!\nThe 8 ball says... \n\n~~{deez[den]}~~\n\n{walkingl[l]} ";

        }
    }
}