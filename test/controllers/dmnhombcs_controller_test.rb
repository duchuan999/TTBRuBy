require 'test_helper'

class DmnhombcsControllerTest < ActionController::TestCase
  setup do
    @dmnhombc = dmnhombcs(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmnhombcs)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmnhombc" do
    assert_difference('Dmnhombc.count') do
      post :create, dmnhombc: { stt: @dmnhombc.stt, ten: @dmnhombc.ten }
    end

    assert_redirected_to dmnhombc_path(assigns(:dmnhombc))
  end

  test "should show dmnhombc" do
    get :show, id: @dmnhombc
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmnhombc
    assert_response :success
  end

  test "should update dmnhombc" do
    patch :update, id: @dmnhombc, dmnhombc: { stt: @dmnhombc.stt, ten: @dmnhombc.ten }
    assert_redirected_to dmnhombc_path(assigns(:dmnhombc))
  end

  test "should destroy dmnhombc" do
    assert_difference('Dmnhombc.count', -1) do
      delete :destroy, id: @dmnhombc
    end

    assert_redirected_to dmnhombcs_path
  end
end
