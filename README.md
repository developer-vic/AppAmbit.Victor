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

### 2. Configure App Keys

Edit `MauiProgram.cs` and replace the app keys with your actual AppAmbit app keys for each platform:

```csharp
#if ANDROID
    string appAmbitAppKey = "YOUR-ANDROID-APP-KEY";
    builder.UseAppAmbit(appAmbitAppKey);
#elif IOS
    string appAmbitAppKey = "YOUR-IOS-APP-KEY";
    builder.UseAppAmbit(appAmbitAppKey);
#endif
```

The SDK automatically selects the correct app key based on the platform being built.

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

- ✅ **Android**: Builds and runs successfully (net9.0-android)
- ✅ **iOS**: Builds and runs successfully (net9.0-ios)

---

## Testing Checklist

- [x] Replace app keys in `MauiProgram.cs` with actual app keys
- [x] Build Android app: `dotnet build -f net9.0-android`
- [x] Deploy to Android device/emulator
- [x] Test each button in the UI
- [x] Verify events appear in AppAmbit dashboard
- [x] Test crash reporting (app will restart)
- [x] Verify crash appears in dashboard on next launch
- [x] Build iOS app: `dotnet build -f net9.0-ios`
- [x] Test on iOS device
- [x] Verify all features work on both platforms

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

- **Creating Apps**: Simple and intuitive process
- **App Keys**: Easy to find and copy for each platform
- **Analytics Dashboard**: Events appear correctly with all properties
- **Crash Reports**: Crashes are captured and displayed with stack traces
- **Overall Experience**: Dashboard is clean and easy to navigate

---

## What Worked ✅

1. **Creating App and Launching with APP ID**: Works perfectly on both Android and iOS platforms
2. **All Test Buttons**: Each test button in the UI works correctly:
   - Track Sample Event ✅
   - Track Event with Properties ✅
   - Log Error Message ✅
   - Log Warning Message ✅
   - Test Crash ✅
3. **Platform-Specific App Keys**: The SDK correctly uses the appropriate app key for each platform
4. **SDK Integration**: Simple and straightforward - just one line per platform in `MauiProgram.cs`
5. **End-to-End Testing**: Analytics events, logs, and crash reports all appear correctly in the AppAmbit dashboard

---

## Issues Found 🐛

1. **Website Registration/Login Not Working** (RESOLVED)
   - **Issue**: Initial attempts to register or login at https://appambit.com/onboarding/welcome resulted in 500 Server Error
   - **Status**: ✅ Resolved - The issue was fixed and registration/login now works

2. **Email Verification for Google Sign-In**
   - **Issue**: When signing in with Google, email verification emails are being sent but going to spam folder instead of inbox
   - **Impact**: Users may miss verification emails or think the system isn't working
   - **Recommendation**: AppAmbit should review email deliverability settings and consider removing email verification requirement for OAuth providers (Google, GitHub) since they're already verified

3. **Missing Forgot Password Feature**
   - **Issue**: No "Forgot Password" link or option on the login page
   - **Impact**: Users who forget their password cannot reset it through the UI
   - **Recommendation**: Add a "Forgot Password" link on the login page that allows users to reset their password via email

---

## Known Issues

1. **SQLite Warning**: Android build shows a warning about SQLite 16KB page size requirement for Android 16
   - **Impact**: None for current Android versions
   - **Note**: This is from the SQLite dependency, not the AppAmbit SDK

---

## Next Steps

1. ✅ Get AppAmbit app keys from dashboard
2. ✅ Update `MauiProgram.cs` with platform-specific app keys
3. ✅ Build and deploy to Android device
4. ✅ Test all features and verify in dashboard
5. ✅ Build and test on iOS device
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

