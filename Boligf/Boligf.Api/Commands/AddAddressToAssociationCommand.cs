﻿using Boligf.Api.Domain;
using d60.Cirqus.Commands;

namespace Boligf.Api.Commands
{
	public class AddAddressToAssociationCommand : Command<Association>
	{
		public string Id { get; set; }
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }

		public AddAddressToAssociationCommand(string associationId) : base(associationId)
		{
		}

		public override void Execute(Association aggregateRoot)
		{
			aggregateRoot.AddAddress(Id, StreetAddress, City, Zip, Country);
		}
	}
}