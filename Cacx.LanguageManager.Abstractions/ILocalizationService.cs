using System.ComponentModel;
using System.Globalization;

namespace Cacx.LanguageManager.Abstractions;

/// <summary>
/// The localization service interface. It provides basic methods that are needed for localization.
/// You can implement your own localization service by implementing this interface.
/// </summary>
public interface ILocalizationService : INotifyPropertyChanged  
{
    /// <summary>
    /// Sets the current language for the application using the specified culture information.
    /// UI elements and resources will be updated to reflect the new language.
    /// </summary>
    /// <param name="cultureInfo">The culture information to use for setting the application's language. Cannot be null.</param>
    public void SetLanguage(CultureInfo cultureInfo);

    /// <summary>
    /// Updates the current context to use the specified base path for subsequent operations.
    /// You have to call this method when your data context changes, 
    /// such as when you switch from the login screen to the main application.
    /// </summary>
    /// <param name="basePath">The base directory path to set as the context. Cannot be null or empty.</param>
    public void UpdateContext(string basePath);

    /// <summary>
    /// Retrieves the string value associated with the specified key.
    /// </summary>
    /// <param name="key">The key used to identify the string value to retrieve. Cannot be null or empty.</param>
    /// <returns>The string value corresponding to the specified key, or null if the key does not exist.</returns>
    public string GetString(string key);

    /// <summary>
    /// Retrieves the object associated with the specified key.
    /// </summary>
    /// <param name="key">The key that identifies the object to retrieve. Cannot be null.</param>
    /// <returns>The object associated with the specified key, or null if no object is found for the key.</returns>
    public object GetObject(string key);

    /// <summary>
    /// Retrieves a readable stream for the data associated with the specified key.
    /// </summary>
    /// <param name="key">The unique identifier for the data to retrieve. Cannot be null or empty.</param>
    /// <returns>A stream containing the data associated with the specified key. The caller is responsible for disposing the
    /// returned stream.</returns>
    public Stream GetStream(string key);

    /// <summary>
    /// Retrieves the current language setting as a <see cref="CultureInfo"/> instance.
    /// </summary>
    /// <returns>A <see cref="CultureInfo"/> object representing the current language configuration.</returns>
    public CultureInfo GetLanguage();
}
