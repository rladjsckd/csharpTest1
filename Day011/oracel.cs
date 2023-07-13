# 07/13 사원 이름의 두번째 글자라 L인 사원만 출력하세요
SELECT * FROM EMP
WHERE ENAME LIKE'_L%';

#BETWEEN A AND B 급여가 2000이상 3000이하
SELECT * FROM EMP
WHERE SAL BETWEEN 2000 AND 3000;

#부서 번호가 10번인 부서와 부서 번호가 20번인 부서의
#EMPNO , ENAME, SAL, DEPRNO
SELECT EMPNO , ENAME, SAL, DEPTNO FROM EMP
WHERE DEPTNO = 10
UNION
SELECT EMPNO , ENAME, SAL, DEPTNO FROM EMP
WHERE DEPTNO = 20;
#차집합
SELECT EMPNO, ENAME, SAL, DEPTNO FROM EMP
MINUS
SELECT EMPNO , ENAME, SAL, DEPTNO FROM EMP
WHERE DEPTNO = 10;
#교집합
SELECT EMPNO, ENAME, SAL, DEPTNO FROM EMP
INTERSECT
SELECT EMPNO , ENAME, SAL, DEPTNO FROM EMP
WHERE DEPTNO = 10;
#Q1
SELECT * FROM EMP
WHERE ENAME LIKE '%S';
#Q2
SELECT  EMPNO, ENAME, JOB, COMM, DEPTNO FROM EMP
WHERE JOB = 'SALESMAN';
#Q3
SELECT EMPNO, ENAME, SAL, JOB, DEPTNO FROM EMP
WHERE SAL > 2000 AND DEPTNO BETWEEN 20 AND 30;

SELECT EMPNO, ENAME, SAL, JOB, DEPTNO FROM EMP
WHERE SAL > 2000 AND DEPTNO = 20
UNION
SELECT EMPNO, ENAME, SAL, JOB, DEPTNO FROM EMP
WHERE SAL > 2000 AND DEPTNO = 30;
#Q4
SELECT * FROM EMP
MINUS
SELECT * FROM EMP
WHERE SAL BETWEEN 2000 AND 3000;
#Q5
SELECT ENAME, EMPNO, SAL, DEPTNO FROM EMP
WHERE DEPTNO = 30 AND ENAME LIKE '%E%' AND SAL <1000 OR SAL >2000;
#Q6
SELECT * FROM EMP
WHERE COMM IS NULL
AND MGR IS NOT NULL
AND JOB IN('MANAGER', 'CLERK')
AND ENAME NOT LIKE '_L%';
#6장 일반함수/ 오라클 함수
SELECT ENAME, UPPER(ENAME), LOWER(ENAME),
INITCAP(ENAME) FROM EMP;
#6-2
SELECT * FROM EMP
WHERE UPPER(ENAME) = UPPER('jones');
#6-3
SELECT * FROM EMP
WHERE UPPER(ENAME) LIKE UPPER('%king%');

#문자열의 길이
SELECT ENAME, LENGTH(ENAME) FROM EMP;

#사원 이름의 길이가 5이상인 행 출력
SELECT ENAME, LENGTH(ENAME) FROM EMP
WHERE LENGTH(ENAME)>5;
#한글 바이트 수
SELECT LENGTH('한글'), LENGTHB('한글') FROM DUAL;
#SUBSRT(,,) SUBSTR(,)
SELECT JOB, SUBSTR(JOB ,1,2), SUBSTR(JOB,3,2)FROM EMP;
SELECT SUBSTR('900305',1,2), SUBSTR('900305',3,4)
FROM DUAL;
#주민번호 앞자리 뽑기, 뒷자리 뽑기
SELECT SUBSTR('991009-1******',1,2), SUBSTR('991009-1******',3,4),
SUBSTR('991009-1******',1,6), SUBSTR('991009-1******',8,7) FROM DUAL;
#SUBSTR -1값
SELECT JOB, SUBSTR(JOB, -3) FROM EMP;
SELECT SUBSTR('홍길동', -2) FROM DUAL;

#문자열에서 특정 문자 위치를 찾는 INSTR 함수
SELECT INSTR('안녕하세요', '요') AS 위치 FROM DUAL;
#검색 위치가 변경
SELECT INSTR('HELLO, ORACLE','L'),
        INSTR('HELLO, ORACLE','L',5), 
        INSTR('HELLO, ORACLE','L',2,2) 
FROM DUAL;
