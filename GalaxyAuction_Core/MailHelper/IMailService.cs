﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyAuction_Core.MailHelper
{
	public interface IMailService
	{
		public void SendEmail(string subject,string body,string email);
	}
}
