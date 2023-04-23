package com.kulessa.KontasDB.controller;

import com.kulessa.KontasDB.entity.User;
import com.kulessa.KontasDB.models.request.LoginRequest;
import com.kulessa.KontasDB.models.request.UserRequest;
import com.kulessa.KontasDB.models.response.TokenResponse;
import com.kulessa.KontasDB.service.UserService;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.BadCredentialsException;
import org.springframework.security.authentication.DisabledException;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;

import java.io.IOException;
import java.security.Principal;
import java.util.List;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api/users")
public class UserController {
    private final UserService service;
    private final AuthenticationManager authenticationManager;

    @PostMapping
    public ResponseEntity<TokenResponse> createUser(@RequestBody UserRequest request) {
        service.createUser(request);
        return authUser(LoginRequest.builder().email(request.getEmail()).password(request.getPassword()).build());
    }

    @GetMapping
    public ResponseEntity<User> getUserInfo(Principal principal) {
        return ResponseEntity.ok(service.getUserByEmail(principal.getName()));
    }

    @PostMapping("/login")
    public ResponseEntity<TokenResponse> authUser(@RequestBody LoginRequest request) {
        this.authenticate(request);
        return ResponseEntity.ok(TokenResponse.builder().token(this.service.getToken(request)).build());
    }

    private void authenticate(LoginRequest request) {
        try {
            authenticationManager.authenticate(new UsernamePasswordAuthenticationToken(request.getEmail(), request.getPassword()));
        } catch (DisabledException e) {
            throw new DisabledException("USER_DISABLED", e);
        } catch (BadCredentialsException e) {
            throw new BadCredentialsException("INVALID_CREDENTIALS", e);
        }
    }
}
