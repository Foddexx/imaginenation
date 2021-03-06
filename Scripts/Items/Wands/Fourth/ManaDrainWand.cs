using Server.Spells.Fourth;

namespace Server.Items
{
	public class ManaDrainWand : BaseWand
	{
		[Constructable]
		public ManaDrainWand() : base( 11 )
		{
            ItemID = 0xdf4;
            Name = "Mana Drain";
		}

		public ManaDrainWand( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void OnWandUse( Mobile from )
		{
			Cast( new ManaDrainSpell( from, this ) );
		}
	}
}