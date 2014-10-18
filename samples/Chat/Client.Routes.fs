﻿namespace Chat.Client

open TypeInferred.HashBang.Routing

/// This type defines the routes that are serviced by the application.
/// Routes can include query parameters where the parameter types are primitives.
type Routes = RoutesProvider<"""

/                   # Session.LogIn         # Log in here

/sign-up            # Session.SignUp        # Sign up here

/conversation       # Conversation.View     # See conversation(s) here

/user?email=string  # User.View             # See user(s) here

""">