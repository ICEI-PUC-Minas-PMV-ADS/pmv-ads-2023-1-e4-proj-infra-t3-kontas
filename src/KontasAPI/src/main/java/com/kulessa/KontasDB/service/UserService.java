package com.kulessa.KontasDB.service;

import com.kulessa.KontasDB.config.JwtUtil;
import com.kulessa.KontasDB.entity.User;
import com.kulessa.KontasDB.mapper.UserMapper;
import com.kulessa.KontasDB.models.request.LoginRequest;
import com.kulessa.KontasDB.models.request.UserRequest;
import com.kulessa.KontasDB.repository.UserRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

import java.util.ArrayList;

@Service
@RequiredArgsConstructor
public class UserService implements UserDetailsService {
    private final UserRepository repository;
    private final JwtUtil jwtUtil;

    public User createUser(UserRequest request) {
        return repository.save(UserMapper.toUser(request));
    }

    public User getUserByEmail(String email) {
        return repository.findByEmail(email).orElseThrow();
    }

    @Override
    public UserDetails loadUserByUsername(String email) throws UsernameNotFoundException {
        User user = repository.findByEmail(email).orElseThrow();
        return new org.springframework.security.core.userdetails.User(user.getEmail(), user.getPassword(), new ArrayList<>());
    }

    public String getToken(LoginRequest request) {
        return this.jwtUtil.generateToken(repository.findByEmail(request.getEmail()).orElseThrow());
    }
}
