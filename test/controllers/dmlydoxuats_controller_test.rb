require 'test_helper'

class DmlydoxuatsControllerTest < ActionController::TestCase
  setup do
    @dmlydoxuat = dmlydoxuats(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmlydoxuats)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmlydoxuat" do
    assert_difference('Dmlydoxuat.count') do
      post :create, dmlydoxuat: { stt: @dmlydoxuat.stt, ten: @dmlydoxuat.ten }
    end

    assert_redirected_to dmlydoxuat_path(assigns(:dmlydoxuat))
  end

  test "should show dmlydoxuat" do
    get :show, id: @dmlydoxuat
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmlydoxuat
    assert_response :success
  end

  test "should update dmlydoxuat" do
    patch :update, id: @dmlydoxuat, dmlydoxuat: { stt: @dmlydoxuat.stt, ten: @dmlydoxuat.ten }
    assert_redirected_to dmlydoxuat_path(assigns(:dmlydoxuat))
  end

  test "should destroy dmlydoxuat" do
    assert_difference('Dmlydoxuat.count', -1) do
      delete :destroy, id: @dmlydoxuat
    end

    assert_redirected_to dmlydoxuats_path
  end
end
