# AppAmbit SDK Integration - Test App

This is a test application integrating the **AppAmbit .NET MAUI SDK** for analytics, logging, and crash reporting.

## Integration Summary

✅ **SDK Installed**: `com.AppAmbit.Sdk` version 1.0.3  
✅ **Platforms**: Android and iOS  
✅ **Integration**: Complete with test UI for all SDK features

---

## Setup Instructions

### 1. Get Your App Key

1. Sign up/login at [appambit.com](https://appambit.com)
2. Create a new app in the dashboard
3. Copy your app key

### 2. Configure App Key

Edit `MauiProgram.cs` and replace `"YOUR-APPKEY"` with your actual AppAmbit app key:

```csharp
.UseAppAmbit("YOUR-APPKEY") // Replace with your actual app key
```

### 3. Build and Run

**Android:**
```bash
dotnet build -f net9.0-android
# Deploy to device/emulator via Visual Studio or dotnet run
```

**iOS:**
```bash
dotnet build -f net9.0-ios
# Requires Xcode and proper provisioning profiles
```

---

## Features Implemented

### Analytics Tracking
- ✅ Track simple events
- ✅ Track events with custom properties
- ✅ Platform and version information included

### Error Logging
- ✅ Log error messages
- ✅ Log warning messages
- ✅ Structured logging for debugging

### Crash Reporting
- ✅ Test crash button (app will crash and restart)
- ✅ Crashes are automatically captured and reported on next launch

---

## Test UI Features

The app includes a comprehensive test UI with buttons for:

1. **Track Sample Event** - Sends a basic analytics event
2. **Track Event with Properties** - Sends an event with custom properties (Category, FileName, Platform, Version)
3. **Log Error Message** - Logs an error for debugging
4. **Log Warning Message** - Logs a warning message
5. **Test Crash** - Forces an app crash to test crash reporting (red button)

Status messages appear below the buttons to confirm actions.

---

## Build Status

- ✅ **Android**: Builds successfully (net9.0-android)
- ⚠️ **iOS**: Requires Xcode 26.0 (currently have Xcode 16.4) - will build on compatible environment

---

## Testing Checklist

- [ ] Replace `YOUR-APPKEY` in `MauiProgram.cs` with actual app key
- [ ] Build Android app: `dotnet build -f net9.0-android`
- [ ] Deploy to Android device/emulator
- [ ] Test each button in the UI
- [ ] Verify events appear in AppAmbit dashboard
- [ ] Test crash reporting (app will restart)
- [ ] Verify crash appears in dashboard on next launch
- [ ] Build iOS app (requires Xcode 26.0)
- [ ] Test on iOS device
- [ ] Use AppAmbit distribution to send test builds

---

## Feedback & Observations

### Positive Aspects

1. **Simple Integration**: The SDK integration is straightforward - just one line in `MauiProgram.cs`
2. **Clean API**: The `Analytics.TrackEvent()` and `Crashes.LogError()` APIs are intuitive
3. **Good Documentation**: The README on GitHub is clear and helpful
4. **Offline Support**: SDK supports offline batching and retry (mentioned in docs)

### Suggestions for Improvement

1. **App Key Configuration**: Consider supporting configuration via `appsettings.json` or environment variables for easier management
2. **API Documentation**: More detailed XML documentation comments in the SDK would help with IntelliSense
3. **Error Handling**: Could provide more detailed error messages if app key is invalid
4. **Testing**: Consider adding a test mode or mock mode for development/testing

### Dashboard Feedback

*(To be completed after testing in dashboard)*

---

## Known Issues

1. **Xcode Version**: iOS builds require Xcode 26.0, but current environment has Xcode 16.4
   - **Workaround**: Use a machine with Xcode 26.0 or update Xcode version
   - **Note**: This is a .NET MAUI requirement, not an AppAmbit SDK issue

2. **SQLite Warning**: Android build shows a warning about SQLite 16KB page size requirement for Android 16
   - **Impact**: None for current Android versions
   - **Note**: This is from the SQLite dependency, not the AppAmbit SDK

---

## Next Steps

1. Get AppAmbit app key from dashboard
2. Update `MauiProgram.cs` with the app key
3. Build and deploy to Android device
4. Test all features and verify in dashboard
5. Build and test on iOS (when Xcode 26.0 is available)
6. Use AppAmbit distribution to send test builds
7. Log GitHub issue with feedback
8. Share feedback on Discord
9. Share positive feedback on social media

---

## Resources

- **AppAmbit SDK GitHub**: https://github.com/AppAmbit/appambit-sdk-maui
- **Documentation**: https://docs.appambit.com
- **Dashboard**: https://appambit.com
- **Discord**: https://discord.gg

---

## License

This test app uses the AppAmbit SDK. See the [AppAmbit SDK repository](https://github.com/AppAmbit/appambit-sdk-maui) for SDK license information.

