﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD392_AffiliLinker.Services.DTO.AuthenDTO.Request
{
	public class CampaignRequest
	{
		public string CampaignName { get; set; }
		public string? Description { get; set; }
		public string? Introduction { get; set; }
		public string? Policy { get; set; }
		public string? Image { get; set; }
		public string? WebsiteLink { get; set; }
		public string? TargetCustomer { get; set; }
		public string? Zone { get; set; }
		public string? CategoryId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Status { get; set; }
		public Guid UserId { get; set; }
	}

	public class UpdateStatusRequest
	{
		public string Status { get; set; } // "1" for approved, "-1" for rejected
	}
}
