using System.Collections.Generic;



namespace PlayFab.Model
{
	
	public class AndroidDevicePushNotificationRegistrationRequest : PlayFabModelBase
	{
		
		
		/// <summary>
		/// unique token generated by the Google Cloud Messaging service when the title registered to receive push notifications
		/// </summary>
		
		public string DeviceToken { get; set;}
		
		public override void Deserialize (Dictionary<string,object> json)
		{
			
			DeviceToken = (string)JsonUtil.Get<string>(json, "DeviceToken");
		}
	}
}