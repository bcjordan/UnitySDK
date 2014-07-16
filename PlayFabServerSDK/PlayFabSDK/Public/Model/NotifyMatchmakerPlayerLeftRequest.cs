using System.Collections.Generic;



namespace PlayFab.Model
{
	
	public class NotifyMatchmakerPlayerLeftRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique identifier of the Game Server Instance the user is leaving
		/// </summary>
		
		public string ServerId { get; set;}
		
		/// <summary>
		/// PlayFab unique identifier of the user that is leaving the Game Server Instance
		/// </summary>
		
		public string PlayFabId { get; set;}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			ServerId = (string)JsonUtil.Get<string>(json, "ServerId");
			PlayFabId = (string)JsonUtil.Get<string>(json, "PlayFabId");
		}
	}
}