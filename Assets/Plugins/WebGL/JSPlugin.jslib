var JSPlugin = 
{
	JSPluginHelloWorld : function()
	{
		window.alert("Hello, world! - JS in JSPlugin called from Unity");
	}
};
mergeInto(LibraryManager.library, JSPlugin);