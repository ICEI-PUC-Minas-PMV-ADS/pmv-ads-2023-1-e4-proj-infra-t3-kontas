package com.kulessa.KontasDB.repository;

import com.kulessa.KontasDB.entity.ContaPagamento;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface ContaPagamentoRepository extends JpaRepository<ContaPagamento, Integer> {
    Optional<ContaPagamento> findByIdAndContaUserId(Integer id, String userId);
    void deleteByIdAndContaUserId(Integer id, String userId);
}
