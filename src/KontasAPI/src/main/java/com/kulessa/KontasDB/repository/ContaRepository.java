package com.kulessa.KontasDB.repository;

import com.kulessa.KontasDB.entity.Conta;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;

public interface ContaRepository extends JpaRepository<Conta, Integer> {
    List<Conta> findByUserId(String userId);
    Optional<Conta> findByIdAndUserId(Integer id, String userId);
    void deleteByIdAndUserId(Integer id, String userId);
}
